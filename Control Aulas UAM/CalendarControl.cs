using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Schedule;
using DevComponents.Schedule.Model;
using Control_Aulas_UAM.Clases;
using DevComponents.DotNetBar;
using Control_Aulas_UAM.Clases.Db;

namespace Control_Aulas_UAM
{
    public partial class CalendarControl : UserControl
    {
        public delegate void EventHandler(object sender, EventArgs e);
        public event EventHandler OnAgregarClick;
        public event EventHandler OnTabClick;
        public event EventHandler OnViewClick;
        public event EventHandler OnDeleteClick;
        public event EventHandler OnVerClick;
        public event EventHandler OnReprogramadaCheckedChanged;
        public event EventHandler OnBuscarClick;
        public event EventHandler OnDeleteSerieClick;
        public event EventHandler OnNotificarClick;

        bool readOnly;
        public bool ReadOnly { get { return readOnly; } set { readOnly = value; HandleContextMenu(); } }

        public List<Aula> Aulas;

        public Aula SelectedAula{get { return Aulas.Find(item=>item.Referencia==calendarView.SelectedOwner);} }

        public CalendarControl()
        {
            InitializeComponent();
            calendarView.DisplayedOwnersChanged += calendarView_OwnersChanged;
            calendarView.SelectedOwnerChanged += calendarView_OwnersChanged;
            calendarView.SelectedViewChanged += calendarView_SelectedViewChanged;
            ReadOnly = true;
            try
            {
                calendarView.CalendarModel.WorkDays.Add(new WorkDay(DayOfWeek.Saturday));
                WorkTime workStartTime = new WorkTime(5, 0);
                WorkTime workEndTime = new WorkTime(23, 59);
                foreach (WorkDay workDay in calendarView.CalendarModel.WorkDays)
                {
                    workDay.WorkStartTime = workStartTime;
                    workDay.WorkEndTime = workEndTime;
                }
                Aulas = new List<Aula>();
                List<Facultad> facultades = new Conexion().getFacultades();
                foreach (Facultad f in facultades)
                {
                    ColorDef colorDef = new ColorDef(f.Color);
                    AppointmentCategoryColor appointmentCategoryColor = new AppointmentCategoryColor(f.Descripcion, Color.Black, f.Color, colorDef);
                    calendarView.CategoryColors.Add(appointmentCategoryColor);
                    appointmentCategoryColor = new AppointmentCategoryColor(f.Descripcion + "Disabled", Color.Gray, Color.Gray, colorDef);
                    calendarView.CategoryColors.Add(appointmentCategoryColor);
                }
            }
            catch { }
        }

        void calendarView_SelectedViewChanged(object sender, SelectedViewEventArgs e)
        {
            eCalendarView view= e.NewValue;
            switch (view) {
                case DevComponents.DotNetBar.Schedule.eCalendarView.Day: btnDayView.Checked = true; break;
                case DevComponents.DotNetBar.Schedule.eCalendarView.Month: btnMonthView.Checked = true; break;
                case DevComponents.DotNetBar.Schedule.eCalendarView.Week: btnWeekView.Checked = true; break;
            }
        }

        void calendarView_OwnersChanged(object sender, EventArgs e)
        {
            calendarView.DateSelectionStart = null;
            calendarView.DateSelectionEnd = null;
        }

        public void AddAula(Aula aula) {
            Aulas.Add(aula);
            if (calendarView.DisplayedOwners.Count == 0) {
                calendarView.DisplayedOwners.Add(aula.Referencia);
            }
        }

        public void AddAulas(Aula[] aulas) {
            Aulas.AddRange(aulas);
            if (calendarView.DisplayedOwners.Count == 0 && Aulas.Count>0)
            {
                calendarView.DisplayedOwners.Add(Aulas[0].Referencia);
            }
        }
        
        private void btnDayView_Click(object sender, EventArgs e)
        {
            calendarView.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Day;
        }

        private void btnWeekView_Click(object sender, EventArgs e)
        {
            calendarView.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Week;
        }

        private void btnMonthView_Click(object sender, EventArgs e)
        {
            calendarView.SelectedView = DevComponents.DotNetBar.Schedule.eCalendarView.Month;
        }

        private void updateAppointment(Appointment appointment, Asignacion asignacion) {
            String subject;
            String description;
            String toolTip;
            String categoryColor;
            DateTime inicio = asignacion.Inicio;
            DateTime fin = asignacion.Fin;
            String separator = "<br />";
            if (asignacion is AsignacionClase)
            {
                AsignacionClase asignacionClase = (AsignacionClase)asignacion;
                categoryColor = asignacionClase.Grupo.Asignatura.Facultad;
                separator="<br />";
                if (asignacionClase.Reprogramada)
                {
                    appointment.ImageKey = "disabled";
                    appointment.ImageAlign = eImageContentAlignment.BottomRight;
                    categoryColor += "Disabled";
                    appointment.DisplayTemplate = "<strike>[Subject]</strike><br /><strike>[Description]</strike>";
                }
                else
                {
                    appointment.ImageKey = null;
                    appointment.DisplayTemplate = "[Subject]<br />[Description]";
                }
                subject = String.Format("{0} - {1}(G{2})", asignacionClase.Grupo.Asignatura.Referencia, asignacionClase.Grupo.Asignatura.Nombre, asignacionClase.Grupo.NumeroGrupo);
                description = String.Format("{0}{3}({1}/{2})", asignacionClase.Grupo.NombreDocente, asignacionClase.Grupo.CantidadEstudiantes, asignacionClase.Aula.Capacidad,separator);
                toolTip = String.Format("Inicio:{0}{5}Fin:{1}{5}Duración:{2}{5}{3}{5}Periodo:{4}", asignacion.Inicio.ToShortTimeString(), asignacion.Fin.ToShortTimeString(), PeriodoTiempo.GetDuracion(asignacion.Inicio, asignacion.Fin), "Clase", asignacionClase.Grupo.Periodo.Descripcion,separator);
            }
            else
            {
                AsignacionVarios asignacionVarios = (AsignacionVarios)asignacion;
                subject = String.Format("{0}", asignacionVarios.TipoUso.Descripcion);
                toolTip = String.Format("Inicio:{0}{4}Fin:{1}{4}Duración:{2}{4}{3}", asignacion.Inicio.ToShortTimeString(), asignacion.Fin.ToShortTimeString(), PeriodoTiempo.GetDuracion(asignacion.Inicio, asignacion.Fin), asignacionVarios.TipoUso.Descripcion,separator);
                description = String.Format("{0}", asignacionVarios.Observaciones);
                categoryColor = Appointment.CategoryDefault;
                appointment.DisplayTemplate = "[Subject]<br />[Description]";
            }
            if (asignacion.Serie != null)
                toolTip += "<br />Pertenece a una serie";
            appointment.StartTime = inicio;
            appointment.EndTime = fin;
            appointment.Subject = subject;
            appointment.Description = description;
            appointment.Tooltip = toolTip;
            appointment.OwnerKey = asignacion.Aula.Referencia;
            appointment.Tag = asignacion;
            appointment.CategoryColor = categoryColor;
            appointment.Locked = true;
        }

        public void updateAsignacion(Asignacion asignacion){
            try
            {
                Appointment appointment = null;
                if(asignacion is AsignacionClase)
                    appointment = calendarView.CalendarModel.Appointments.ToList().Find(element => ((Asignacion)element.Tag).ID == asignacion.ID && element.Tag is AsignacionClase);
                else if(asignacion is AsignacionVarios)
                    appointment = calendarView.CalendarModel.Appointments.ToList().Find(element => ((Asignacion)element.Tag).ID == asignacion.ID && element.Tag is AsignacionVarios);
                    
                //Appointment appointment=calendarView.CalendarModel.Appointments.ToList().Find(element=>element.Tag==asignacion);
                updateAppointment(appointment, asignacion);
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
            }
        }

        private void calendarView_MouseUp(object sender, MouseEventArgs e)
        {
            BaseView view = sender as BaseView;
            //if(e.Button==MouseButtons.Right){
                if (sender is BaseView)
                    BaseViewMouseUp(sender, e);
                else if (sender is AppointmentView)
                    AppointmentViewMouseUp(sender,e);
                else if (sender is AllDayPanel)
                    AllDayPanelMouseUp(sender);
                else if (sender is TimeRulerPanel)
                    TimeRulerPanelMouseUp();
                else if (sender is TimeLineHeaderPanel)
                    TimeLineHeaderPanelMouseUp(sender, e);
            //}
        }

        private void TimeLineHeaderPanelMouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Header Panel Clicked");
        }

        private void TimeRulerPanelMouseUp()
        {
            //MessageBox.Show("Time Ruler Clicked");
        }

        private void AllDayPanelMouseUp(object sender)
        {
            //MessageBox.Show("All Day Panel Clicked");
        }

        private void AppointmentViewMouseUp(object sender, MouseEventArgs e)
        {
            AppointmentView view = sender as AppointmentView;
            view.IsSelected = true;
            InAppointment.Enabled = (view.Appointment.IsRecurringInstance == false);
            InAppointment.Tag = view;
            if (e.Button == MouseButtons.Right)
            {
                if (((Asignacion)view.Appointment.Tag).Serie != null)
                {
                    if(readOnly)
                        buttonItemBorrarSerie.Visible = false;
                    else
                        buttonItemBorrarSerie.Visible = true;
                }
                else {
                    buttonItemBorrarSerie.Visible = false ;
                }
                if (view.Appointment.Tag is AsignacionClase)
                {
                    AsignacionClase asignacionClase=(AsignacionClase)view.Appointment.Tag;
                    checkBoxItemReprogramada.Checked = asignacionClase.Reprogramada;
                    checkBoxItemReprogramada.Visible = true;
                    if (asignacionClase.Reprogramada)
                    {
                        buttonItemVerAppointment.Visible = false;
                    }
                    else
                    {
                        buttonItemVerAppointment.Visible = true;
                    }
                }
                else
                {
                    checkBoxItemReprogramada.Visible = false;
                    buttonItemVerAppointment.Visible = true;
                }
                ShowContextMenu(InAppointment);
            }
            else {
                if (OnVerClick != null)
                {
                    OnVerClick(view.Appointment.Tag, e);
                }
            }
            //MessageBox.Show("Appointment View Clicked");
        }

        private void BaseViewMouseUp(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Base View Clicked");
            BaseView view = sender as BaseView;

            if (view != null)
            {
                eViewArea area = view.GetViewAreaFromPoint(e.Location);
                switch (area)
                {
                    case eViewArea.InContent:
                        InContentMouseUp(view, e);
                        break;

                    case eViewArea.InTab:
                        InTabMouseUp(view,e);
                        break;

                    case eViewArea.InDayOfWeekHeader:
                        //InDayOfWeekHeaderMouseUp(view);
                        break;

                    case eViewArea.InMonthHeader:
                        //InMonthHeaderMouseUp(view);
                        break;

                    case eViewArea.InSideBarPanel:
                        //InSideBarMouseUp(view);
                        break;

                    case eViewArea.InCondensedView:
                        //InCondensedViewMouseUp();
                        break;
                }
            }
        }

        private void InContentMouseUp(BaseView view, MouseEventArgs e)
        {
            
                if (OnViewClick != null)
                {
                    OnViewClick(view, e);
                }
                DateTime startDate, endDate;
                if (calendarView.GetDateSelectionFromPoint(e.Location, out startDate, out endDate))
                {
                    if (!IsDateSelected(startDate, endDate))
                    {
                        calendarView.DateSelectionStart = startDate;
                        calendarView.DateSelectionEnd = endDate;
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    ShowContextMenu(InContentContextMenu);
                }
            
        }

        private void ShowContextMenu(DevComponents.DotNetBar.ButtonItem cm)
        {
            Point pt = MousePosition;
            cm.Popup(pt);
        }

        private bool IsDateSelected(DateTime startDate, DateTime endDate)
        {
            bool isDateSelected = false;
            if (calendarView.DateSelectionStart.HasValue && calendarView.DateSelectionEnd.HasValue)
            {
                if (calendarView.DateSelectionStart.Value <= startDate &&
                    calendarView.DateSelectionEnd.Value >= endDate)
                    isDateSelected=true;
            }

            return isDateSelected;
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                if (OnAgregarClick != null)
                {
                    OnAgregarClick(this, e);
                }
            }
            catch { }
            //DateTime startDate = calendarView.DateSelectionStart.GetValueOrDefault();
            //DateTime endDate = calendarView.DateSelectionEnd.GetValueOrDefault();
            //AddNewAppointment(startDate,endDate);
            //AppointmentForm appointmentForm = new AppointmentForm();
            //appointmentForm.StartDate = startDate;
            //appointmentForm.EndDate = endDate;
            //if (appointmentForm.ShowDialog()== DialogResult.OK) {
                //startDate = appointmentForm.StartDate;
                //endDate = appointmentForm.EndDate;
                //AddNewAppointment(startDate, endDate,appointmentForm.Subject,appointmentForm.Description,appointmentForm.Description);   
            //}
        }

        public void AddNewAppointment(DateTime startDate, DateTime endDate)
        {
            AddNewAppointment(startDate,endDate, "New appointment!","This is a new appointment",
                "This is a Custom tooltip for this new appointment");
        }

        public void AddNewAppointment(DateTime startDate, DateTime endDate, String subject, String description, String toolTip)
        {
            Appointment appointment = new Appointment();
            appointment.StartTime = startDate;
            appointment.EndTime = endDate;
            appointment.Subject = subject;
            appointment.Description = description;
            appointment.Tooltip = toolTip;
            appointment.OwnerKey = calendarView.SelectedOwner;
            calendarView.CalendarModel.Appointments.Add(appointment);
        }

        public void AddNewAppointment(Asignacion owner,DateTime startDate, DateTime endDate, String subject, String description, String toolTip)
        {
            Appointment appointment = new Appointment();
            appointment.StartTime = startDate;
            appointment.EndTime = endDate;
            appointment.Subject = subject;
            appointment.Description = description;
            appointment.Tooltip = toolTip;
            appointment.OwnerKey = owner.Aula.Referencia;
            appointment.Tag = owner;
            appointment.Locked = true;
            calendarView.CalendarModel.Appointments.Add(appointment);
        }

        public void AddAsignacion(Asignacion asignacion)
        {
            Appointment appointment = new Appointment();
            updateAppointment(appointment, asignacion);
            calendarView.CalendarModel.Appointments.Add(appointment);
        }

        private void InTabOcultar_Click(object sender, EventArgs e)
        {
            if (calendarView.DisplayedOwners.Count > 1)
            {
                if (calendarView.SelectedOwnerIndex >= 0)
                    calendarView.DisplayedOwners.RemoveAt(calendarView.SelectedOwnerIndex);
            }
        }

        private void InTabMouseUp(object sender,MouseEventArgs e)
        {
            OnTabClick(sender, e);
            if (e.Button == MouseButtons.Right)
            {
                if (Aulas != null)
                {
                    if (Aulas.Count > 1)
                    {
                        ResetTabContextMenu();
                        if (calendarView.DisplayedOwners.Count > 1)
                        {
                            InTabOcultar.Visible = true;
                            InTabOcultar.Text = "Ocultar '" + calendarView.SelectedOwner + "'";
                        }
                        else
                        {
                            InTabOcultar.Visible = false;
                        }
                        int index = InTabContextMenu.SubItems.IndexOf(InTabAddNewTab);

                        if (AddAltUsersToMenu(index + 1, MiAddOwnerTabClick) <= 0)
                            InTabAddNewTab.Visible = false;
                        else
                            InTabAddNewTab.Visible = true;

                        index = InTabContextMenu.SubItems.IndexOf(InTabReplaceTab);

                        if (AddAltUsersToMenu(index + 1, MiReplaceTabClick) <= 0)
                            InTabReplaceTab.Visible = false;
                        else
                        {
                            InTabReplaceTab.Text = "Reemplazar '" + calendarView.SelectedOwner + "'";
                            InTabReplaceTab.Visible = true;
                        }
                        ShowContextMenu(InTabContextMenu);
                    }
                }
            }
        }

        private void ResetTabContextMenu()
        {
            for (int i = InTabContextMenu.SubItems.Count - 1; i >= 0; i--)
            {
                if (InTabContextMenu.SubItems[i].Name == "")
                    InTabContextMenu.SubItems.RemoveAt(i);
            }
        }

        private int AddAltUsersToMenu(int index, System.EventHandler evh)
        {
            int addedIndex=0;;
            if (Aulas != null)
            {
                int n = index;
                foreach (Aula owner in Aulas)
                {
                    if (!calendarView.DisplayedOwners.Contains(owner.Referencia))
                    {
                        ButtonItem bi = new ButtonItem("", owner.Referencia);
                        bi.Tag = owner;
                        bi.Click += evh;

                        InTabContextMenu.SubItems.Insert(index++, bi);
                    }
                }
                addedIndex= (index - n);
            }
            return addedIndex;
                
        }

        void MiAddOwnerTabClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            if (bi != null)
                calendarView.DisplayedOwners.Insert(calendarView.SelectedOwnerIndex, bi.Text);
            OnTabClick(sender, e);
        }

        void MiReplaceTabClick(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            calendarView.DisplayedOwners[calendarView.SelectedOwnerIndex] = ((Aula)bi.Tag).Referencia;
        }

        private void buttonItemDeleteAppointment_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            AppointmentView view = bi.Parent.Tag as AppointmentView;
            if (view != null)
            {
                if (OnDeleteClick != null)
                {
                    OnDeleteClick(view.Appointment.Tag, e);
                    calendarView.CalendarModel.Appointments.Remove(view.Appointment);
                }
            }
            
        }

        private void buttonItemEditarAppointment_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            AppointmentView view = bi.Parent.Tag as AppointmentView;
            if (view != null)
            {
                if(OnVerClick!=null)
                    OnVerClick(view.Appointment.Tag, e);
            }
        }

        private void buttonItemAulasView_Click(object sender, EventArgs e)
        {
            if (calendarView.DisplayedOwners.Count == 0 && Aulas.Count>0) {
                calendarView.DisplayedOwners.Add(Aulas[0].Referencia);
            }
        }

        private void buttonItemTAulaView_Click(object sender, EventArgs e)
        {
            calendarView.DisplayedOwners.Clear();
        }

        private void checkBoxItemReprogramada_Click(object sender, EventArgs e)
        {
            CheckBoxItem ci = sender as CheckBoxItem;
            AppointmentView view = ci.Parent.Tag as AppointmentView;
            if (OnReprogramadaCheckedChanged != null)
            {
                AsignacionClase asignacion = ((AsignacionClase)view.Appointment.Tag);
                asignacion.Reprogramada = ci.Checked;
                updateAsignacion(asignacion);
                OnReprogramadaCheckedChanged(view.Appointment.Tag, e);
            }
        }

        private void HandleContextMenu()
        {
            if (readOnly)
            {
                btnAddAppointment.Enabled = false;
                buttonItemDeleteAppointment.Enabled = false;
                checkBoxItemReprogramada.Enabled = false;
            }
            else {
                btnAddAppointment.Enabled = true;
                buttonItemDeleteAppointment.Enabled = true;
                checkBoxItemReprogramada.Enabled = true;
            }

        }

        private void buttonItemBuscar_Click(object sender, EventArgs e)
        {
            if (OnBuscarClick != null)
                OnBuscarClick(sender, e);
        }

        private void buttonItemMultiUser_Click(object sender, EventArgs e)
        {
            if (calendarView.DisplayedOwners.Count == 0 && Aulas.Count > 0)
            {
                calendarView.DisplayedOwners.Add(Aulas[0].Referencia);
            }
        }

        private void buttonItemSingleUser_Click(object sender, EventArgs e)
        {
            calendarView.DisplayedOwners.Clear();
        }

        private void InContentContextMenu_Click(object sender, EventArgs e)
        {

        }

        private void buttonItemBorrarSerie_Click(object sender, EventArgs e)
        {
            ButtonItem bi = sender as ButtonItem;
            AppointmentView view = bi.Parent.Tag as AppointmentView;
            if (view != null)
            {
                calendarView.CalendarModel.Appointments.Remove(view.Appointment);
                try
                {
                    Asignacion asignacion = (Asignacion)view.Appointment.Tag;
                    List<Appointment> appointments = null;
                    if (asignacion is AsignacionClase)
                    {
                        appointments = calendarView.CalendarModel.Appointments.ToList().FindAll(element => ((Asignacion)element.Tag).Serie != null && element.Tag is AsignacionClase);
                        appointments = appointments.FindAll(element => ((Asignacion)element.Tag).Serie.ID==asignacion.Serie.ID);
                    }
                    else if (asignacion is AsignacionVarios)
                    {
                        appointments = calendarView.CalendarModel.Appointments.ToList().FindAll(element => ((Asignacion)element.Tag).Serie != null && element.Tag is AsignacionVarios);
                        appointments = appointments.FindAll(element => ((Asignacion)element.Tag).Serie.ID == asignacion.Serie.ID);
                    }

                    Conexion conexion = new Conexion();
                    for (int i = 0; i < appointments.Count; i++)
                    {
                        try
                        {
                            conexion.borrarAsignacion((Asignacion)appointments[i].Tag);
                            calendarView.CalendarModel.Appointments.Remove(appointments[i]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    conexion.borrarSerie(asignacion.Serie);
                    conexion.borrarAsignacion(asignacion);
                    MessageBox.Show("Serie Eliminada");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        private void buttonItemNotificar_Click(object sender, EventArgs e)
        {
            if (OnNotificarClick != null) {
                OnNotificarClick(sender, e);
            }
        }

    }
}
