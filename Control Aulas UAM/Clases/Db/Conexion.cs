using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using System.Data;
using Control_Aulas_UAM.Clases.Db;
using System.Drawing;
using Control_Aulas_UAM;

namespace Control_Aulas_UAM.Clases
{
    class Conexion
    {
        private SqlConnection connection=null;
        private SqlCommand command=null;
        private SqlTransaction transaction=null;
        private String lastUpdated = null;

        public String LastUpdated
        {
            get { return lastUpdated; }
        }


        public Conexion()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ScheduleTesting.Properties.Settings.uam_agendaConnectionString"].ToString());

        }

        
        /*--------------------Catalogo de Facultades-------------------------*/

        public List<Facultad> getFacultades()
        {
            SqlDataReader dataReader = null;
            List<Facultad> facultades = new List<Facultad>();
            try
            {
                string query = "Select * from facultad";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Facultad fac = new Facultad();
                    fac.Id = Convert.ToInt32(dataReader["id_facultad"].ToString());
                    fac.Descripcion = dataReader["descripcion"].ToString();
                    fac.Color = Color.FromArgb((int)dataReader["color"]);
                    facultades.Add(fac);
                }
                return facultades;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Facultad. "+e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();                  
            }
        }

        public int cantFacultades()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from facultad";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Facultad. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertFacultad(Facultad facultad)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into Facultad(Descripcion,color) values(@descripcion,@color);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@color", SqlDbType.Int));
                this.command.Parameters["@descripcion"].Value = facultad.Descripcion;
                this.command.Parameters["@color"].Value = facultad.Color.ToArgb();
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarFacultad(Facultad facultad)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update Facultad set descripcion=@descripcion,color=@color where id_facultad=@id;";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@color", SqlDbType.Int));
                this.command.Parameters["@descripcion"].Value = facultad.Descripcion;
                this.command.Parameters["@color"].Value = facultad.Color.ToArgb();
                this.command.Parameters["@id"].Value = facultad.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion."+ ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarFacultad(Facultad facultad)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from Facultad where id_facultad=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = facultad.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO FACULTADES------------------------*/

        /*--------------------Catalogo de Edificios-------------------------*/

        public List<Edificio> getEdificios()
        {
            SqlDataReader dataReader = null;
            List<Edificio> edificios = new List<Edificio>();
            try
            {
                string query = "Select * from edificio";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Edificio edi = new Edificio();
                    edi.Id = Convert.ToInt32(dataReader["id_edificio"].ToString());
                    edi.Descripcion = dataReader["descripcion"].ToString();
                    edificios.Add(edi);
                }
                return edificios;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Edificio. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantEdificios()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from edificio";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Edificio. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertEdificio(Edificio edificio)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into edificio(Descripcion) values(@descripcion);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters["@descripcion"].Value = edificio.Descripcion;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarEdificio(Edificio edificio)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update edificio set descripcion=@descripcion where id_edificio=@id;";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@descripcion"].Value = edificio.Descripcion;
                this.command.Parameters["@id"].Value = edificio.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarEdificio(Edificio edificio)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from edificio where id_edificio=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = edificio.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO Edificios------------------------*/

        /*--------------------Catalogo de Docentes-------------------------*/

        public List<Docente> getDocentes()
        {
            SqlDataReader dataReader = null;
            List<Docente> docentes = new List<Docente>();
            try
            {
                string query = "Select * from docente";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Docente docente = new Docente();
                    docente.Id = Convert.ToInt32(dataReader["id_docente"].ToString());
                    docente.Nombre = dataReader["nombre"].ToString();
                    docentes.Add(docente);
                }
                return docentes;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Docente. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantDocentes()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from docente";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Docente. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertDocente(Docente docente)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into docente(nombre) values(@nombre);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 50));
                this.command.Parameters["@nombre"].Value = docente.Nombre;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarDocente(Docente docente)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update docente set nombre=@nombre where id_docente=@id;";
                this.command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@nombre"].Value = docente.Nombre;
                this.command.Parameters["@id"].Value = docente.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarDocente(Docente docente)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from docente where id_docente=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = docente.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO DOCENTES------------------------*/

        /*--------------------Catalogo de Periodos-------------------------*/

        public List<Periodo> getPeriodos()
        {
            SqlDataReader dataReader = null;
            List<Periodo> Periodos = new List<Periodo>();
            try
            {
                string query = "Select * from periodo";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Periodo Periodo = new Periodo();
                    Periodo.Id = Convert.ToInt32(dataReader["id_periodo"].ToString());
                    Periodo.FechaInicio = Convert.ToDateTime(dataReader["periodo_inicio"].ToString());
                    Periodo.FechaFin = Convert.ToDateTime(dataReader["periodo_fin"].ToString());
                    Periodo.Descripcion = dataReader["descripcion"].ToString();
                    Periodos.Add(Periodo);
                }
                return Periodos;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Periodo. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantPeriodos()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from periodo";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Periodo. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertPeriodo(Periodo Periodo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into periodo(periodo_inicio,periodo_fin,descripcion) values(@fechaInicio,@fechaFin,@descripcion);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@fechaInicio",SqlDbType.DateTime));
                this.command.Parameters.Add(new SqlParameter("@fechaFin", SqlDbType.DateTime));
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters["@fechaInicio"].Value = Periodo.FechaInicio;
                this.command.Parameters["@fechaFin"].Value = Periodo.FechaFin;
                this.command.Parameters["@descripcion"].Value = Periodo.Descripcion;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarPeriodo(Periodo Periodo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update Periodo set periodo_inicio=@fechaInicio,periodo_fin=@fechaFin,descripcion=@descripcion where id_Periodo=@id;";
                this.command.Parameters.Add(new SqlParameter("@fechaInicio",SqlDbType.DateTime));
                this.command.Parameters.Add(new SqlParameter("@fechaFin",SqlDbType.DateTime));
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@fechaInicio"].Value = Periodo.FechaInicio;
                this.command.Parameters["@fechaFin"].Value = Periodo.FechaFin;
                this.command.Parameters["@descripcion"].Value = Periodo.Descripcion;
                this.command.Parameters["@id"].Value = Periodo.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarPeriodo(Periodo Periodo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from Periodo where id_Periodo=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = Periodo.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO PeriodoS------------------------*/

        /*--------------------Catalogo de AsignaturaCategorias-------------------------*/

        public List<AsignaturaCategoria> getAsignaturaCategorias()
        {
            SqlDataReader dataReader = null;
            List<AsignaturaCategoria> AsignaturaCategorias = new List<AsignaturaCategoria>();
            try
            {
                string query = "Select * from asignatura_categoria";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AsignaturaCategoria edi = new AsignaturaCategoria();
                    edi.Id = Convert.ToInt32(dataReader["id_categoria"].ToString());
                    edi.Descripcion = dataReader["descripcion"].ToString();
                    AsignaturaCategorias.Add(edi);
                }
                return AsignaturaCategorias;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AsignaturaCategoria. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantAsignaturaCategorias()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from asignatura_categoria";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AsignaturaCategoria. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertAsignaturaCategoria(AsignaturaCategoria AsignaturaCategoria)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into asignatura_categoria(Descripcion) values(@descripcion);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters["@descripcion"].Value = AsignaturaCategoria.Descripcion;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarAsignaturaCategoria(AsignaturaCategoria AsignaturaCategoria)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update asignatura_categoria set descripcion=@descripcion where id_categoria=@id;";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@descripcion"].Value = AsignaturaCategoria.Descripcion;
                this.command.Parameters["@id"].Value = AsignaturaCategoria.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarAsignaturaCategoria(AsignaturaCategoria AsignaturaCategoria)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from asignatura_categoria where id_categoria=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = AsignaturaCategoria.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO AsignaturaCategorias------------------------*/

        /*--------------------Catalogo de Asignaturas-------------------------*/

        public List<Asignatura> getAsignaturas()
        {
            SqlDataReader dataReader = null;
            List<Asignatura> Asignaturas = new List<Asignatura>();
            try
            {
                string query = "Select * from Vista_Asignaturas";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Asignatura Asignatura = new Asignatura();
                    Asignatura.Id = Convert.ToInt32(dataReader["id_asignatura"].ToString());
                    Asignatura.Nombre = dataReader["nombre"].ToString();
                    Asignatura.IdCategoria = Convert.ToInt32(dataReader["id_categoria"].ToString());
                    Asignatura.Categoria = dataReader["descripcionCategoria"].ToString();
                    Asignatura.IdFacultad = Convert.ToInt32(dataReader["id_facultad"].ToString());
                    Asignatura.Facultad = dataReader["descripcionFacultad"].ToString();
                    Asignatura.Referencia = dataReader["referencia"].ToString();
                    Asignatura.Carrera = dataReader["carrera_refe"].ToString();
                    Asignaturas.Add(Asignatura);
                }
                return Asignaturas;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Asignatura. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public List<Asignatura> getAsignaturasConGrupo()
        {
            SqlDataReader dataReader = null;
            List<Asignatura> Asignaturas = new List<Asignatura>();
            try
            {
                string query = "Select * from Vista_AsignaturasConGrupo";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Asignatura Asignatura = new Asignatura();
                    Asignatura.Id = Convert.ToInt32(dataReader["id_asignatura"].ToString());
                    Asignatura.Nombre = dataReader["nombre"].ToString();
                    Asignatura.IdCategoria = Convert.ToInt32(dataReader["id_categoria"].ToString());
                    Asignatura.Categoria = dataReader["descripcionCategoria"].ToString();
                    Asignatura.IdFacultad = Convert.ToInt32(dataReader["id_facultad"].ToString());
                    Asignatura.Facultad = dataReader["descripcionFacultad"].ToString();
                    Asignatura.Referencia = dataReader["referencia"].ToString();
                    Asignatura.Carrera = dataReader["carrera_refe"].ToString();
                    Asignaturas.Add(Asignatura);
                }
                return Asignaturas;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Asignatura. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantAsignaturas()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from Vista_Asignaturas";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Asignatura. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertAsignatura(Asignatura Asignatura)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into asignatura(id_categoria,id_facultad,nombre,referencia) values(@idCategoria,@idFacultad,@nombre,@referencia);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@idCategoria", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@idFacultad", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@referencia", SqlDbType.VarChar, 20));
                this.command.Parameters["@idCategoria"].Value = Asignatura.IdCategoria;
                this.command.Parameters["@idFacultad"].Value = Asignatura.IdFacultad;
                this.command.Parameters["@nombre"].Value = Asignatura.Nombre;
                this.command.Parameters["@referencia"].Value = Asignatura.Referencia;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarAsignatura(Asignatura Asignatura)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update asignatura set id_categoria=@idCategoria,id_facultad=@idFacultad,nombre=@nombre,referencia=@referencia where id_asignatura=@id;";
                this.command.Parameters.Add(new SqlParameter("@idFacultad", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@idCategoria", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@referencia", SqlDbType.VarChar, 20));
                this.command.Parameters["@idFacultad"].Value = Asignatura.IdFacultad;
                this.command.Parameters["@idCategoria"].Value = Asignatura.IdCategoria;
                this.command.Parameters["@nombre"].Value = Asignatura.Nombre;
                this.command.Parameters["@id"].Value = Asignatura.Id;
                this.command.Parameters["@referencia"].Value = Asignatura.Referencia;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarAsignatura(Asignatura Asignatura)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from asignatura where id_asignatura=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = Asignatura.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO Asignaturas------------------------*/

        /*--------------------Catalogo de Grupos-------------------------*/

        public List<Grupo> getGrupos(Asignatura a)
        {
            SqlDataReader dataReader = null;
            List<Grupo> Grupos = new List<Grupo>();
            try
            {
                string query = "Select * from Vista_Grupos where idAsignatura=@idAsignatura";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                command.Parameters.Add(new SqlParameter("@idAsignatura", SqlDbType.Int));
                command.Parameters["@idAsignatura"].Value = a.Id;
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Grupo Grupo = new Grupo();
                    Grupo.Id = Convert.ToInt32(dataReader["id"].ToString());
                    Grupo.CantidadEstudiantes = Convert.ToInt32(dataReader["cantEstudiantes"].ToString());
                    
                    Asignatura asignatura = new Asignatura();
                    asignatura.Id = Convert.ToInt32(dataReader["idAsignatura"].ToString());
                    asignatura.Nombre = dataReader["nombreAsignatura"].ToString();
                    Grupo.Asignatura = asignatura;

                    Docente docente = new Docente();
                    docente.Id = Convert.ToInt32(dataReader["idDocente"].ToString());
                    docente.Nombre = dataReader["nombreDocente"].ToString();
                    Grupo.Docente = docente;

                    Periodo periodo = new Periodo();
                    periodo.Id = Convert.ToInt32(dataReader["idPeriodo"].ToString());
                    periodo.Descripcion = dataReader["descripcionPeriodo"].ToString();
                    Grupo.Periodo = periodo;

                    Grupo.NumeroGrupo = Convert.ToInt32(dataReader["Grupo"].ToString());

                    Grupos.Add(Grupo);
                }
                return Grupos;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Grupo. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
/*
        public int cantGrupos()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from Vista_Grupos";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Grupo. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
        */
        public Boolean insertGrupo(Grupo Grupo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into Grupo(id_asignatura,id_docente,id_periodo,cant_estudiante) values(@idAsignatura,@idDocente,@idPeriodo,@cantInscritos);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@idAsignatura", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@idDocente", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@idPeriodo",SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@cantInscritos", SqlDbType.Int));
                this.command.Parameters["@idAsignatura"].Value = Grupo.Asignatura.Id;
                this.command.Parameters["@idDocente"].Value = Grupo.Docente.Id;
                this.command.Parameters["@idPeriodo"].Value = Grupo.Periodo.Id;
                this.command.Parameters["@cantInscritos"].Value = Grupo.CantidadEstudiantes;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }
        
        public Boolean actualizarGrupo(Grupo Grupo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update grupo set id_asignatura=@idAsignatura,id_docente=@idDocente,cant_estudiante=@inscritos,id_periodo=@idPeriodo where id_grupo=@id;";
                this.command.Parameters.Add(new SqlParameter("@idAsignatura", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@idDocente", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@inscritos", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@idPeriodo", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@idAsignatura"].Value = Grupo.Asignatura.Id;
                this.command.Parameters["@idDocente"].Value = Grupo.Docente.Id;
                this.command.Parameters["@inscritos"].Value = Grupo.CantidadEstudiantes;
                this.command.Parameters["@idPeriodo"].Value = Grupo.Periodo.Id;
                this.command.Parameters["@id"].Value = Grupo.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }
        
        public Boolean borrarGrupo(Grupo Grupo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from Grupo where id_Grupo=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = Grupo.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO Grupos------------------------*/
        /*--------------------Catalogo de AulaTipos-------------------------*/

        public List<AulaTipo> getAulaTipos()
        {
            SqlDataReader dataReader = null;
            List<AulaTipo> AulaTipos = new List<AulaTipo>();
            try
            {
                string query = "Select * from aula_tipo";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AulaTipo edi = new AulaTipo();
                    edi.Id = Convert.ToInt32(dataReader["id_tipo"].ToString());
                    edi.Descripcion = dataReader["descripcion"].ToString();
                    AulaTipos.Add(edi);
                }
                return AulaTipos;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaTipo. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantAulaTipos()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from aula_tipo";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaTipo. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertAulaTipo(AulaTipo AulaTipo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into aula_tipo(Descripcion) values(@descripcion);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters["@descripcion"].Value = AulaTipo.Descripcion;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarAulaTipo(AulaTipo AulaTipo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update aula_tipo set descripcion=@descripcion where id_tipo=@id;";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@descripcion"].Value = AulaTipo.Descripcion;
                this.command.Parameters["@id"].Value = AulaTipo.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarAulaTipo(AulaTipo AulaTipo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from aula_tipo where id_tipo=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = AulaTipo.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO AulaTipos------------------------*/
        /*--------------------Catalogo de AulaTipoUsoUsos-------------------------*/

        public List<AulaTipoUso> getAulaTipoUso()
        {
            SqlDataReader dataReader = null;
            List<AulaTipoUso> AulaTipoUsoUsos = new List<AulaTipoUso>();
            try
            {
                string query = "Select * from aula_tipo_uso";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AulaTipoUso edi = new AulaTipoUso();
                    edi.Id = Convert.ToInt32(dataReader["id_tipo_uso"].ToString());
                    edi.Descripcion = dataReader["descripcion"].ToString();
                    AulaTipoUsoUsos.Add(edi);
                }
                return AulaTipoUsoUsos;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaTipoUso. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantAulaTipoUsos()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from aula_tipo_uso";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaTipoUso. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertAulaTipoUso(AulaTipoUso AulaTipoUso)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into aula_tipo_uso(Descripcion) values(@descripcion);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters["@descripcion"].Value = AulaTipoUso.Descripcion;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarAulaTipoUso(AulaTipoUso AulaTipoUso)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update aula_tipo_uso set descripcion=@descripcion where id_tipo_uso=@id;";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@descripcion"].Value = AulaTipoUso.Descripcion;
                this.command.Parameters["@id"].Value = AulaTipoUso.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarAulaTipoUso(AulaTipoUso AulaTipoUso)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from aula_tipo_uso where id_tipo_uso=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = AulaTipoUso.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO AulaTipoUsos------------------------*/
        /*--------------------Catalogo de AulaEstadoUsos-------------------------*/

        public List<AulaEstado> getAulaEstado()
        {
            SqlDataReader dataReader = null;
            List<AulaEstado> AulaEstado = new List<AulaEstado>();
            try
            {
                string query = "Select * from aula_estado";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AulaEstado edi = new AulaEstado();
                    edi.Id = Convert.ToInt32(dataReader["id_estado"].ToString());
                    edi.Descripcion = dataReader["descripcion"].ToString();
                    AulaEstado.Add(edi);
                }
                return AulaEstado;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantAulaEstados()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from aula_estado";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertAulaEstado(AulaEstado AulaEstado)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into aula_estado(Descripcion) values(@descripcion);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters["@descripcion"].Value = AulaEstado.Descripcion;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarAulaEstado(AulaEstado AulaEstado)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update aula_estado set descripcion=@descripcion where id_estado=@id;";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@descripcion"].Value = AulaEstado.Descripcion;
                this.command.Parameters["@id"].Value = AulaEstado.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarAulaEstado(AulaEstado AulaEstado)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from aula_estado where id_estado=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = AulaEstado.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        /*--------------------FIN CATALOGO AulaEstados------------------------*/
        /*--------------------Catalogo de Aulas-------------------------*/

        public List<Aula> getAulas()
        {
            SqlDataReader dataReader = null;
            List<Aula> Aulas = new List<Aula>();
            try
            {
                string query = "Select * from Vista_Aulas";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Aula aula = new Aula();
                    aula.Id =Convert.ToInt32(dataReader["id_aula"].ToString());
                    aula.IdTipo = Convert.ToInt32(dataReader["id_tipo"].ToString());
                    aula.NombreTipo = dataReader["aulaTipo"].ToString();
                    aula.Nombre = dataReader["descripcionAula"].ToString();
                    aula.Capacidad = Convert.ToInt32(dataReader["capacidad"].ToString());
                    aula.IdEdificio = Convert.ToInt32(dataReader["id_edificio"]);
                    aula.NombreEdificio = dataReader["edificio"].ToString();
                    aula.Piso = Convert.ToInt32(dataReader["piso"].ToString());
                    aula.IdEstado = Convert.ToInt32(dataReader["id_estado"].ToString());
                    aula.NombreEstado = dataReader["estado"].ToString();
                    aula.Referencia = dataReader["referencia"].ToString();
                    Aulas.Add(aula);
                }
                return Aulas;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
        /*Este metodo devuelve un Aula segun el id*/
        public Aula getAula(int id)
        {
            SqlDataReader dataReader = null;
            string query = "Select * from Vista_Aulas where id_aula=" + id;
            SqlCommand command2 = new SqlCommand(query, connection); ;
            try
            {
                
                
                if (command2.Connection.State.Equals(ConnectionState.Closed))
                {
                    command2.Connection.Open();
                }
                dataReader = command2.ExecuteReader();
                Aula aula=new Aula();
                while (dataReader.Read())
                {
                    aula.Id = Convert.ToInt32(dataReader["id_aula"].ToString());
                    aula.IdTipo = Convert.ToInt32(dataReader["id_tipo"].ToString());
                    aula.NombreTipo = dataReader["aulaTipo"].ToString();
                    aula.Nombre = dataReader["descripcionAula"].ToString();
                    aula.Capacidad = Convert.ToInt32(dataReader["capacidad"].ToString());
                    aula.IdEdificio = Convert.ToInt32(dataReader["id_edificio"]);
                    aula.NombreEdificio = dataReader["edificio"].ToString();
                    aula.Piso = Convert.ToInt32(dataReader["piso"].ToString());
                    aula.IdEstado = Convert.ToInt32(dataReader["id_estado"].ToString());
                    aula.NombreEstado = dataReader["estado"].ToString();
                    aula.Referencia = dataReader["referencia"].ToString();
                }
                return aula;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command2.Connection.Close();
            }
        }
        public int cantAulas()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from Vista_Aulas";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertAula(Aula Aula)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into aula(id_tipo,descripcion,capacidad,id_edificio,piso,id_estado,referencia) values(@id_tipo,@descripcion,@capacidad,@id_edificio,@piso,@id_estado,@referencia);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@id_tipo",DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 100));
                this.command.Parameters.Add(new SqlParameter("@capacidad", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@id_edificio", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@piso", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@id_estado", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@referencia", SqlDbType.VarChar, 10));
                this.command.Parameters["@id_tipo"].Value = Aula.IdTipo;
                this.command.Parameters["@descripcion"].Value = Aula.Nombre;
                this.command.Parameters["@capacidad"].Value = Aula.Capacidad;
                this.command.Parameters["@id_edificio"].Value = Aula.IdEdificio;
                this.command.Parameters["@piso"].Value = Aula.Piso;
                this.command.Parameters["@id_estado"].Value = Aula.IdEstado;
                this.command.Parameters["@referencia"].Value = Aula.Referencia;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarAula(Aula Aula)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update aula set id_tipo=@id_tipo,descripcion=@descripcion,capacidad=@capacidad,id_edificio=@id_edificio,piso=@piso,id_estado=@id_estado,referencia=@referencia where id_aula=@id_aula;";
                this.command.Parameters.Add(new SqlParameter("@id_tipo", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@capacidad", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@id_edificio", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@piso", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@id_estado", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@referencia", SqlDbType.VarChar, 10));
                this.command.Parameters.Add(new SqlParameter("@id_aula", DbType.Int32));
                this.command.Parameters["@id_tipo"].Value = Aula.IdTipo;
                this.command.Parameters["@descripcion"].Value = Aula.Nombre;
                this.command.Parameters["@capacidad"].Value = Aula.Capacidad;
                this.command.Parameters["@id_edificio"].Value = Aula.IdEdificio;
                this.command.Parameters["@piso"].Value = Aula.Piso;
                this.command.Parameters["@id_estado"].Value = Aula.IdEstado;
                this.command.Parameters["@referencia"].Value = Aula.Referencia;
                this.command.Parameters["@id_aula"].Value = Aula.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarAula(Aula Aula)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from aula where id_aula=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = Aula.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        /*--------------------FIN CATALOGO Aulas------------------------*/

        public List<AsignacionVarios> getAsignacionesVarios()
        {
            SqlDataReader dataReader = null;
            List<AsignacionVarios> Aulas = new List<AsignacionVarios>();
            try
            {
                
                string query = "Select * from Vista_AsignacionVarios";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {


                    AsignacionVarios asig = new AsignacionVarios();
                    asig.ID = Convert.ToInt32(dataReader["id_asignacion"].ToString());
                    asig.Aula = new Aula();
                    asig.Aula.Id = Convert.ToInt32(dataReader["id_aula"].ToString());
                    asig.Aula.IdTipo = Convert.ToInt32(dataReader["aula_id_tipo"].ToString());
                    asig.Aula.Nombre = dataReader["aula_descripcion"].ToString();
                    asig.Aula.Capacidad = Convert.ToInt32(dataReader["aula_capacidad"].ToString());
                    asig.Aula.IdEdificio = Convert.ToInt32(dataReader["edificioId"].ToString());
                    asig.Aula.NombreEdificio = dataReader["edificioDescripcion"].ToString();
                    asig.Aula.Piso = Convert.ToInt32(dataReader["aulaPiso"].ToString());
                    asig.Aula.IdEstado = Convert.ToInt32(dataReader["estadoId"].ToString());
                    asig.Aula.NombreEstado = dataReader["estadoDescripcion"].ToString();
                    asig.Aula.Referencia = dataReader["aulaReferencia"].ToString();
                    asig.Inicio = Convert.ToDateTime(dataReader["inicio"].ToString());
                    asig.Fin = Convert.ToDateTime(dataReader["fin"].ToString());
                    asig.TipoUso = new AulaTipoUso();
                    asig.TipoUso.Id = Convert.ToInt32(dataReader["tipoUsoId"].ToString());
                    asig.TipoUso.Descripcion = dataReader["tipoUsoDescripcion"].ToString();
                    asig.Observaciones = dataReader["observaciones"].ToString();
                    Serie serie = null;
                    String s = dataReader["serie"].ToString();
                    if (s != null)
                    {
                        if (s.Length > 0 && s != "0")
                        {
                            serie = new Serie();
                            serie.ID = Convert.ToInt32(s);
                            serie.Descripcion = dataReader["serieDescripcion"].ToString();
                        }
                    }
                    asig.Serie = serie;
                    Aulas.Add(asig);
                }
                return Aulas;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public List<AsignacionClase> getAsignacionesClase()
        {
            SqlDataReader dataReader = null;
            List<AsignacionClase> asignacionesClase = new List<AsignacionClase>();
            try
            {
                
                string query = "Select * from Vista_AsignacionClases";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AsignacionClase asig = new AsignacionClase();
                    asig.ID = Convert.ToInt32(dataReader["id_asignacion"].ToString());
                    asig.Aula = new Aula();
                    asig.Aula.Id = Convert.ToInt32(dataReader["id_aula"].ToString());
                    asig.Aula.IdTipo = Convert.ToInt32(dataReader["id_tipo"].ToString());
                    asig.Aula.NombreTipo = dataReader["aulaTipoDescripcion"].ToString();
                    asig.Aula.Nombre = dataReader["aulaDescripcion"].ToString();
                    asig.Aula.Capacidad = Convert.ToInt32(dataReader["aulaCapacidad"].ToString());
                    asig.Aula.IdEdificio = Convert.ToInt32(dataReader["id_edificio"].ToString());
                    asig.Aula.NombreEdificio = dataReader["edificioDescripcion"].ToString();
                    asig.Aula.Piso = Convert.ToInt32(dataReader["aulaPiso"].ToString());
                    asig.Aula.IdEstado = Convert.ToInt32(dataReader["id_estado"].ToString());
                    asig.Aula.NombreEstado = dataReader["aulaEstadoDescripcion"].ToString();
                    asig.Aula.Referencia = dataReader["aulaReferencia"].ToString();
                    asig.Grupo = new Grupo();
                    asig.Grupo.Id = Convert.ToInt32(dataReader["id_grupo"].ToString());
                    asig.Grupo.Asignatura = new Asignatura();
                    asig.Grupo.Asignatura.Id = Convert.ToInt32(dataReader["id_asignatura"].ToString());
                    asig.Grupo.Asignatura.Nombre = dataReader["asignaturaNombre"].ToString();
                    asig.Grupo.Asignatura.IdFacultad = Convert.ToInt32(dataReader["id_facultad"].ToString());
                    asig.Grupo.Asignatura.Facultad = dataReader["facultaDescripcion"].ToString();
                    asig.Grupo.Asignatura.IdCategoria = Convert.ToInt32(dataReader["id_categoria"].ToString());
                    asig.Grupo.Asignatura.Categoria = dataReader["asignaturaCategoriaDescripcion"].ToString();
                    asig.Grupo.Asignatura.Referencia = dataReader["asignaturaReferencia"].ToString();
                    asig.Grupo.Docente = new Docente();
                    asig.Grupo.Docente.Id = Convert.ToInt32(dataReader["id_docente"].ToString());
                    asig.Grupo.Docente.Nombre = dataReader["docenteNombre"].ToString();
                    asig.Grupo.CantidadEstudiantes = Convert.ToInt32(dataReader["grupoInscritos"].ToString());
                    asig.Grupo.Periodo = new Periodo();
                    asig.Grupo.Periodo.Id = Convert.ToInt32(dataReader["id_periodo"].ToString());
                    asig.Grupo.Periodo.FechaInicio = Convert.ToDateTime(dataReader["periodoInicio"].ToString());
                    asig.Grupo.Periodo.FechaFin = Convert.ToDateTime(dataReader["periodoFin"].ToString());
                    asig.Grupo.Periodo.Descripcion = dataReader["periodoDescripcion"].ToString();
                    asig.Inicio = Convert.ToDateTime(dataReader["inicio"].ToString());
                    asig.Fin = Convert.ToDateTime(dataReader["fin"].ToString());
                    asig.Reprogramada = (bool)dataReader["reprogramada"];

                    Serie serie=null;
                    String s= dataReader["serie"].ToString();
                    if (s != null)
                    {
                        if (s.Length > 0 && s != "0")
                        {
                            serie = new Serie();
                            serie.ID = Convert.ToInt32(s);
                            serie.Descripcion = dataReader["serieDescripcion"].ToString();
                        }
                    }
                    asig.Serie = serie;
                    asignacionesClase.Add(asig);
                }
                return asignacionesClase;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public Boolean insertAsignacion(ref Asignacion Asignacion)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                if (Asignacion is AsignacionClase)
                {
                    AsignacionClase asig = (AsignacionClase)Asignacion;
                    this.command.CommandText = "insert into asignacion_clase(id_aula,id_grupo,inicio,fin,serie,reprogramada) values(@id_aula,@id_grupo,@inicio,@fin,@serie,@reprogramada);" + "SELECT CAST(scope_identity() AS int)";
                    this.command.Parameters.Add(new SqlParameter("@id_aula", DbType.Int32));
                    this.command.Parameters.Add(new SqlParameter("@id_grupo", DbType.Int32));
                    this.command.Parameters.Add(new SqlParameter("@inicio", DbType.DateTime));
                    this.command.Parameters.Add(new SqlParameter("@fin", DbType.DateTime));
                    this.command.Parameters.Add(new SqlParameter("@reprogramada", DbType.Boolean));

                    this.command.Parameters["@id_aula"].Value = asig.Aula.Id;
                    this.command.Parameters["@id_grupo"].Value = asig.Grupo.Id;
                    this.command.Parameters["@inicio"].Value = asig.Inicio;
                    this.command.Parameters["@fin"].Value = asig.Fin;
                    this.command.Parameters["@reprogramada"].Value = asig.Reprogramada;

                    this.command.Parameters.Add(new SqlParameter("@serie", DbType.Int32));
                    if (Asignacion.Serie != null)
                    {
                        this.command.Parameters["@serie"].Value = Asignacion.Serie.ID;
                    }
                    else
                    {
                        this.command.Parameters["@serie"].Value = DBNull.Value;
                    }                    
                }
                else
                {
                    AsignacionVarios asig = (AsignacionVarios)Asignacion;
                    this.command.CommandText = "insert into asignacion_varios(id_aula,inicio,fin,id_tipo_uso,observaciones,serie) values(@id_aula,@inicio,@fin,@id_tipo_uso,@observaciones,@serie);" + "SELECT CAST(scope_identity() AS int)";
                    this.command.Parameters.Add(new SqlParameter("@id_aula", DbType.Int32));
                    this.command.Parameters.Add(new SqlParameter("@inicio", DbType.DateTime));
                    this.command.Parameters.Add(new SqlParameter("@fin", DbType.DateTime));
                    this.command.Parameters.Add(new SqlParameter("@id_tipo_uso", DbType.Int32));
                    this.command.Parameters.Add(new SqlParameter("@observaciones", DbType.String));

                    this.command.Parameters["@id_aula"].Value = asig.Aula.Id;
                    this.command.Parameters["@inicio"].Value = asig.Inicio;
                    this.command.Parameters["@fin"].Value = asig.Fin;
                    this.command.Parameters["@id_tipo_uso"].Value = asig.TipoUso.Id;
                    this.command.Parameters["@observaciones"].Value = asig.Observaciones;

                    this.command.Parameters.Add(new SqlParameter("@serie", DbType.Int32));
                    if (asig.Serie != null)
                    {
                        this.command.Parameters["@serie"].Value = asig.Serie.ID;
                    }
                    else
                    {
                        this.command.Parameters["@serie"].Value = DBNull.Value;
                    }
                }
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                Asignacion.ID = Convert.ToInt32(lastUpdated);
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }
        public Boolean actualizarAsignacion(Asignacion Asignacion)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                if (Asignacion is AsignacionClase)
                {
                    AsignacionClase asig = (AsignacionClase)Asignacion;
                    this.command.CommandText = "update asignacion_clase set id_aula=@id_aula,id_grupo=@id_grupo,inicio=@inicio,fin=@fin, reprogramada=@reprogramada, serie=@serie where id_asignacion=@id;";
                    this.command.Parameters.Add(new SqlParameter("@id_aula", DbType.Int32));
                    this.command.Parameters.Add(new SqlParameter("@id_grupo", DbType.Int32));
                    this.command.Parameters.Add(new SqlParameter("@inicio", DbType.DateTime));
                    this.command.Parameters.Add(new SqlParameter("@fin", DbType.DateTime));
                    this.command.Parameters.Add(new SqlParameter("@id", DbType.Int32));
                    this.command.Parameters.Add(new SqlParameter("@reprogramada", DbType.Binary));

                    this.command.Parameters["@id_aula"].Value = asig.Aula.Id;
                    this.command.Parameters["@id_grupo"].Value = asig.Grupo.Id;
                    this.command.Parameters["@inicio"].Value = asig.Inicio;
                    this.command.Parameters["@fin"].Value = asig.Fin;
                    this.command.Parameters["@id"].Value = asig.ID;
                    this.command.Parameters["@reprogramada"].Value = asig.Reprogramada;

                    this.command.Parameters.Add(new SqlParameter("@serie", DbType.Int32));
                    if (asig.Serie != null)
                    {
                        this.command.Parameters["@serie"].Value = asig.Serie.ID;
                    }
                    else
                    {
                        this.command.Parameters["@serie"].Value = DBNull.Value;
                    }

                }
                else
                {
                    AsignacionVarios asig = (AsignacionVarios)Asignacion;
                    this.command.CommandText = "update asignacion_varios set id_aula=@id_aula,inicio=@inicio,fin=@fin,id_tipo_uso=@id_tipo_uso,observaciones=@observaciones, serie=@serie where id_asignacion=@id;";
                    this.command.Parameters.Add(new SqlParameter("@id_aula", DbType.Int32));
                    this.command.Parameters.Add(new SqlParameter("@inicio", DbType.DateTime));
                    this.command.Parameters.Add(new SqlParameter("@fin", DbType.DateTime));
                    this.command.Parameters.Add(new SqlParameter("@id_tipo_uso", DbType.Int32));
                    this.command.Parameters.Add(new SqlParameter("@observaciones", DbType.String));
                    this.command.Parameters.Add(new SqlParameter("@id", DbType.Int32));
                    this.command.Parameters["@id_aula"].Value = asig.Aula.Id;
                    this.command.Parameters["@inicio"].Value = asig.Inicio;
                    this.command.Parameters["@fin"].Value = asig.Fin;
                    this.command.Parameters["@id_tipo_uso"].Value = asig.TipoUso.Id;
                    this.command.Parameters["@observaciones"].Value = asig.Observaciones;
                    this.command.Parameters["@id"].Value = asig.ID;

                    this.command.Parameters.Add(new SqlParameter("@serie", DbType.Int32));
                    if (asig.Serie != null)
                    {
                        this.command.Parameters["@serie"].Value = asig.Serie.ID;
                    }
                    else
                    {
                        this.command.Parameters["@serie"].Value = DBNull.Value;
                    }

                }
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }
        public Boolean borrarAsignacion(Asignacion Asignacion)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                if (Asignacion is AsignacionVarios)
                {
                    AsignacionVarios asp=(AsignacionVarios)Asignacion;
                    this.command.CommandText = "delete from asignacion_varios where id_asignacion=@id;";
                    this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    this.command.Parameters["@id"].Value = asp.ID;
                }
                else
                {

                    AsignacionClase asp = (AsignacionClase)Asignacion;
                    this.command.CommandText = "delete from asignacion_clase where id_asignacion=@id;";
                    this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    this.command.Parameters["@id"].Value = asp.ID;
                }
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------Catalogo de AulasEquipos-------------------------*/

        public List<AulaEquipo> getAulasEquipos()
        {
            SqlDataReader dataReader = null;
            List<AulaEquipo> Aulas = new List<AulaEquipo>();
            try
            {
                string query = "Select * from Vista_AulasEquipos";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AulaEquipo aula = new AulaEquipo();
                    aula.Id = Convert.ToInt32(dataReader["id_aula"].ToString());
                    aula.IdEquipo = Convert.ToInt32(dataReader["id_equipo"].ToString());
                    aula.DescripcionEquipo = dataReader["descripcionEquipo"].ToString();
                    aula.ObservacionEquipo = dataReader["observacionEquipo"].ToString();
                    aula.Cantidad = Convert.ToInt32(dataReader["cantidad"].ToString());
                    aula.Observaciones = dataReader["observaciones"].ToString();
                    Aulas.Add(aula);
                }
                return Aulas;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public List<AulaEquipo> getAulasEquipos(int id)
        {
            SqlDataReader dataReader = null;
            List<AulaEquipo> Aulas = new List<AulaEquipo>();
            try
            {
                string query = "Select * from Vista_AulasEquipos where id_aula=@id";
                command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@id",DbType.Int32));
                command.Parameters["@id"].Value=id;
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AulaEquipo aula = new AulaEquipo();
                    aula.Id = Convert.ToInt32(dataReader["id_aula"].ToString());
                    aula.IdEquipo = Convert.ToInt32(dataReader["id_equipo"].ToString());
                    aula.DescripcionEquipo = dataReader["descripcionEquipo"].ToString();
                    aula.ObservacionEquipo = dataReader["observacionEquipo"].ToString();
                    aula.Cantidad = Convert.ToInt32(dataReader["cantidad"].ToString());
                    aula.Observaciones = dataReader["observaciones"].ToString();
                    Aulas.Add(aula);
                }
                return Aulas;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
        /*
        public int cantAulasEquipos()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from Vista_AulasEquipos";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }*/

        public Boolean insertAulaEquipo(AulaEquipo AulaEquipo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into aula_equipo(id_aula,id_equipo,cantidad,observaciones) values(@id_aula,@id_equipo,@cantidad,@observaciones);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@id_aula", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@id_equipo", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@cantidad", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 50));
                this.command.Parameters["@id_aula"].Value = AulaEquipo.Id;
                this.command.Parameters["@id_equipo"].Value = AulaEquipo.IdEquipo;
                this.command.Parameters["@cantidad"].Value = AulaEquipo.Cantidad;
                this.command.Parameters["@observaciones"].Value = AulaEquipo.Observaciones;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarAulaEquipo(AulaEquipo AulaEquipo,int idEquipo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update aula_equipo set id_equipo=@id_equipo,cantidad=@cantidad,observaciones=@observaciones where id_aula=@id_aula and id_equipo=@temp;";
                this.command.Parameters.Add(new SqlParameter("@id_aula", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@id_equipo", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@temp", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@cantidad", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 50));
                this.command.Parameters["@id_aula"].Value = AulaEquipo.Id;
                this.command.Parameters["@id_equipo"].Value = AulaEquipo.IdEquipo;
                this.command.Parameters["@cantidad"].Value = AulaEquipo.Cantidad;
                this.command.Parameters["@observaciones"].Value = AulaEquipo.Observaciones;
                this.command.Parameters["@temp"].Value = idEquipo;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarAulaEquipo(AulaEquipo Aula)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from aula_equipo where id_aula=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = Aula.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        /*--------------------FIN CATALOGO Aulas------------------------*/

        /*--------------------Catalogo de Equipos-------------------------*/

        public List<Equipo> getEquipos()
        {
            SqlDataReader dataReader = null;
            List<Equipo> Equipos = new List<Equipo>();
            try
            {
                string query = "Select * from equipo";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Equipo edi = new Equipo();
                    edi.Id = Convert.ToInt32(dataReader["id_equipo"].ToString());
                    edi.Descripcion = dataReader["descripcion"].ToString();
                    edi.Observacion = dataReader["observacion"].ToString();
                    Equipos.Add(edi);
                }
                return Equipos;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Equipo. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public List<Serie> getSeries()
        {
            SqlDataReader dataReader = null;
            List<Serie> series = new List<Serie>();
            try
            {

                string query = "Select * from serie";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Serie serie = new Serie();
                    serie.ID = Convert.ToInt32(dataReader["id_serie"].ToString());
                    serie.Descripcion = dataReader["descripcion"].ToString();
                    series.Add(serie);
                }
                return series;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Series. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertSerie(ref Serie serie)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into serie(descripcion) values(@descripcion);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@descripcion", DbType.String));
                this.command.Parameters["@descripcion"].Value = serie.Descripcion;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                if (lastUpdated != null)
                {
                    serie.ID = Convert.ToInt32(lastUpdated);
                }
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }
        public Boolean actualizarSerie(Serie serie)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;
            try
            {
                this.command.CommandText = "update serie set descripcion=@descripcion where id_serie=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", DbType.Int32));
                this.command.Parameters.Add(new SqlParameter("@descripcion", DbType.String));
                this.command.Parameters["@id"].Value = serie.ID;
                this.command.Parameters["@descripcion"].Value = serie.Descripcion;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }
        public Boolean borrarSerie(Serie serie)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {

                this.command.CommandText = "delete from serie where id_serie=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = serie.ID;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }
        public List<AsignacionClase> getAsignacionesClase(String filtro)
        {
            SqlDataReader dataReader = null;
            List<AsignacionClase> asignacionesClase = new List<AsignacionClase>();
            try
            {
                string query = "Select * from Vista_AsignacionClases WHERE "+filtro;
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AsignacionClase asig = new AsignacionClase();
                    asig.ID = Convert.ToInt32(dataReader["id_asignacion"].ToString());
                    asig.Aula = new Aula();
                    asig.Aula.Id = Convert.ToInt32(dataReader["id_aula"].ToString());
                    asig.Aula.IdTipo = Convert.ToInt32(dataReader["id_tipo"].ToString());
                    asig.Aula.NombreTipo = dataReader["aulaTipoDescripcion"].ToString();
                    asig.Aula.Nombre = dataReader["aulaDescripcion"].ToString();
                    asig.Aula.Capacidad = Convert.ToInt32(dataReader["aulaCapacidad"].ToString());
                    asig.Aula.IdEdificio = Convert.ToInt32(dataReader["id_edificio"].ToString());
                    asig.Aula.NombreEdificio = dataReader["edificioDescripcion"].ToString();
                    asig.Aula.Piso = Convert.ToInt32(dataReader["aulaPiso"].ToString());
                    asig.Aula.IdEstado = Convert.ToInt32(dataReader["id_estado"].ToString());
                    asig.Aula.NombreEstado = dataReader["aulaEstadoDescripcion"].ToString();
                    asig.Aula.Referencia = dataReader["aulaReferencia"].ToString();
                    asig.Grupo = new Grupo();
                    asig.Grupo.Id = Convert.ToInt32(dataReader["id_grupo"].ToString());
                    asig.Grupo.Asignatura = new Asignatura();
                    asig.Grupo.Asignatura.Id = Convert.ToInt32(dataReader["id_asignatura"].ToString());
                    asig.Grupo.Asignatura.Nombre = dataReader["asignaturaNombre"].ToString();
                    asig.Grupo.Asignatura.IdFacultad = Convert.ToInt32(dataReader["id_facultad"].ToString());
                    asig.Grupo.Asignatura.Facultad = dataReader["facultaDescripcion"].ToString();
                    asig.Grupo.Asignatura.IdCategoria = Convert.ToInt32(dataReader["id_categoria"].ToString());
                    asig.Grupo.Asignatura.Categoria = dataReader["asignaturaCategoriaDescripcion"].ToString();
                    asig.Grupo.Asignatura.Referencia = dataReader["asignaturaReferencia"].ToString();
                    asig.Grupo.Docente = new Docente();
                    asig.Grupo.Docente.Id = Convert.ToInt32(dataReader["id_docente"].ToString());
                    asig.Grupo.Docente.Nombre = dataReader["docenteNombre"].ToString();
                    asig.Grupo.CantidadEstudiantes = Convert.ToInt32(dataReader["grupoInscritos"].ToString());
                    asig.Grupo.Periodo = new Periodo();
                    asig.Grupo.Periodo.Id = Convert.ToInt32(dataReader["id_periodo"].ToString());
                    asig.Grupo.Periodo.FechaInicio = Convert.ToDateTime(dataReader["periodoInicio"].ToString());
                    asig.Grupo.Periodo.FechaFin = Convert.ToDateTime(dataReader["periodoFin"].ToString());
                    asig.Grupo.Periodo.Descripcion = dataReader["periodoDescripcion"].ToString();
                    asig.Inicio = Convert.ToDateTime(dataReader["inicio"].ToString());
                    asig.Fin = Convert.ToDateTime(dataReader["fin"].ToString());
                    asig.Reprogramada = (bool)dataReader["reprogramada"];

                    Serie serie = null;
                    String s = dataReader["serie"].ToString();
                    if (s != null)
                    {
                        if (s.Length > 0 && s != "0")
                        {
                            serie = new Serie();
                            serie.ID = Convert.ToInt32(s);
                            serie.Descripcion = dataReader["serieDescripcion"].ToString();
                        }
                    }
                    asig.Serie = serie;
                    asignacionesClase.Add(asig);
                }
                return asignacionesClase;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public List<AsignacionVarios> getAsignacionesVarios(String filtro)
        {
            SqlDataReader dataReader = null;
            List<AsignacionVarios> AsignacionesVarios = new List<AsignacionVarios>();
            try
            {

                string query = "Select * from Vista_AsignacionVarios WHERE " + filtro;
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AsignacionVarios asig = new AsignacionVarios();
                    asig.ID = Convert.ToInt32(dataReader["id_asignacion"].ToString());
                    asig.Aula = new Aula();
                    asig.Aula.Id = Convert.ToInt32(dataReader["id_aula"].ToString());
                    asig.Aula.IdTipo = Convert.ToInt32(dataReader["aula_id_tipo"].ToString());
                    asig.Aula.Nombre = dataReader["aula_descripcion"].ToString();
                    asig.Aula.Capacidad = Convert.ToInt32(dataReader["aula_capacidad"].ToString());
                    asig.Aula.IdEdificio = Convert.ToInt32(dataReader["edificioId"].ToString());
                    asig.Aula.NombreEdificio = dataReader["edificioDescripcion"].ToString();
                    asig.Aula.Piso = Convert.ToInt32(dataReader["aulaPiso"].ToString());
                    asig.Aula.IdEstado = Convert.ToInt32(dataReader["estadoId"].ToString());
                    asig.Aula.NombreEstado = dataReader["estadoDescripcion"].ToString();
                    asig.Aula.Referencia = dataReader["aulaReferencia"].ToString();
                    asig.Inicio = Convert.ToDateTime(dataReader["inicio"].ToString());
                    asig.Fin = Convert.ToDateTime(dataReader["fin"].ToString());
                    asig.TipoUso = new AulaTipoUso();
                    asig.TipoUso.Id = Convert.ToInt32(dataReader["tipoUsoId"].ToString());
                    asig.TipoUso.Descripcion = dataReader["tipoUsoDescripcion"].ToString();
                    asig.Observaciones = dataReader["observaciones"].ToString();

                    Serie serie = null;
                    String s = dataReader["serie"].ToString();
                    if (s != null)
                    {
                        if (s.Length > 0 && s != "0")
                        {
                            serie = new Serie();
                            serie.ID = Convert.ToInt32(s);
                            serie.Descripcion = dataReader["serieDescripcion"].ToString();
                        }
                    }
                    asig.Serie = serie;
                    AsignacionesVarios.Add(asig);
                }
                return AsignacionesVarios;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AulaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantEquipos()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from equipo";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Equipo. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertEquipo(Equipo Equipo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into equipo(descripcion,observacion) values(@descripcion);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@dobservacion", SqlDbType.NVarChar, 50));
                this.command.Parameters["@descripcion"].Value = Equipo.Descripcion;
                this.command.Parameters["@observacion"].Value = Equipo.Observacion;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarEquipo(Equipo Equipo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update equipo set descripcion=@descripcion,observacion=@observacion where id_equipo=@id;";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@observacion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@descripcion"].Value = Equipo.Descripcion;
                this.command.Parameters["@observacion"].Value = Equipo.Observacion;
                this.command.Parameters["@id"].Value = Equipo.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarEquipo(Equipo Equipo)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from equipo where id_equipo=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = Equipo.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO Equipos------------------------*/

        /*--------------------Catalogo de Alertas-------------------------*/

        public List<Alerta> getAlertas()
        {
            SqlDataReader dataReader = null;
            List<Alerta> Alertas = new List<Alerta>();
            try
            {
                string query = "Select * from alerta";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    Alerta edi = new Alerta();
                    edi.Id = Convert.ToInt32(dataReader["id_alerta"].ToString());
                    edi.IdAula = Convert.ToInt32(dataReader["id_aula"].ToString());
                    edi.Descripcion = dataReader["descripcion"].ToString();
                    edi.FechaEvento = Convert.ToDateTime(dataReader["fecha_evento"].ToString());
                    edi.FechaRecordatorio = Convert.ToDateTime(dataReader["fecha_recordatorio"].ToString());
                    edi.Observaciones = dataReader["observaciones"].ToString();
                    edi.IdAlertaEstado = Convert.ToInt32(dataReader["id_alerta_estado"]);
                    edi.UsuarioEmisor = Convert.ToInt32(dataReader["usuario_emisor"]);
                    edi.UsuarioDestinatario = Convert.ToInt32(dataReader["usuario_destinatario"]);
                    Alertas.Add(edi);
                }
                return Alertas;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Alerta. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public List<Alerta> getAlertas(int idUsuario)
        {
            SqlDataReader dataReader2 = null;
            List<Alerta> Alertas = new List<Alerta>();
            try
            {
                string query = "Select * from alerta where usuario_destinatario=" + idUsuario;
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader2 = command.ExecuteReader();
                while (dataReader2.Read())
                {
                    Alerta edi = new Alerta();
                    edi.Id = Convert.ToInt32(dataReader2["id_alerta"].ToString());
                    edi.IdAula = Convert.ToInt32(dataReader2["id_aula"].ToString());
                    edi.Descripcion = dataReader2["descripcion"].ToString();
                    edi.FechaEvento = Convert.ToDateTime(dataReader2["fecha_evento"].ToString());
                    edi.FechaRecordatorio = Convert.ToDateTime(dataReader2["fecha_recordatorio"].ToString());
                    edi.Observaciones = dataReader2["observaciones"].ToString();
                    edi.IdAlertaEstado = Convert.ToInt32(dataReader2["id_alerta_estado"]);
                    edi.UsuarioEmisor = Convert.ToInt32(dataReader2["usuario_emisor"]);
                    edi.UsuarioDestinatario = Convert.ToInt32(dataReader2["usuario_destinatario"]);
                    edi.Realizada = Convert.ToBoolean(dataReader2["realizada"]);
                    Alertas.Add(edi);
                }
                command.Connection.Close();
                foreach (Alerta a in Alertas)
                {
                    a.Aula = this.getAula(a.IdAula);
                }
                foreach (Alerta a in Alertas)
                {
                    a.DescripcionEstado = this.getDescripcionAlertaEstado(a.IdAlertaEstado);
                }
                return Alertas;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Alerta. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
        public int cantAlertas()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from alerta";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Alerta. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertAlerta(Alerta Alerta)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into alerta(id_aula,descripcion,fecha_evento,fecha_recordatorio,observaciones,id_alerta_estado,usuario_emisor,usuario_destinatario,realizada) values(@id_aula,@descripcion,@fecha_evento,@fecha_recordatorio,@observaciones,@id_alerta_estado,@usuario_emisor,@usuario_destinatario,@realizada);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@id_aula", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@usuario_emisor", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@usuario_destinatario", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@id_alerta_estado", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@fecha_evento", SqlDbType.DateTime));
                this.command.Parameters.Add(new SqlParameter("@fecha_recordatorio", SqlDbType.DateTime));
                this.command.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@realizada", SqlDbType.Bit));
                this.command.Parameters["@descripcion"].Value = Alerta.Descripcion;
                this.command.Parameters["@id_aula"].Value = Alerta.IdAula;
                this.command.Parameters["@id_alerta_estado"].Value = Alerta.IdAlertaEstado;
                this.command.Parameters["@fecha_evento"].Value = Alerta.FechaEvento;
                this.command.Parameters["@fecha_recordatorio"].Value = Alerta.FechaRecordatorio;
                this.command.Parameters["@observaciones"].Value = Alerta.Observaciones;
                this.command.Parameters["@usuario_emisor"].Value = Alerta.UsuarioEmisor;
                this.command.Parameters["@usuario_destinatario"].Value = Alerta.UsuarioDestinatario;
                this.command.Parameters["@realizada"].Value = false;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarAlerta(Alerta Alerta)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update alerta set id_aula=@id_aula,descripcion=@descripcion,fecha_evento=@fecha_evento,fecha_recordatorio=@fecha_recordatorio,observaciones=@observaciones,id_alerta_estado=@id_alerta_estado,usuario_emisor=@emisor,usuario_destinatario=@destinatario,realizada=@realizada where id_alerta=@id;";
                this.command.Parameters.Add(new SqlParameter("@id_aula", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@emisor", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@destinatario", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@id_alerta_estado", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@fecha_evento", SqlDbType.DateTime));
                this.command.Parameters.Add(new SqlParameter("@fecha_recordatorio", SqlDbType.DateTime));
                this.command.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@realizada", SqlDbType.Bit));
                this.command.Parameters["@descripcion"].Value = Alerta.Descripcion;
                this.command.Parameters["@id_aula"].Value = Alerta.IdAula;
                this.command.Parameters["@id_alerta_estado"].Value = Alerta.IdAlertaEstado;
                this.command.Parameters["@fecha_evento"].Value = Alerta.FechaEvento;
                this.command.Parameters["@fecha_recordatorio"].Value = Alerta.FechaRecordatorio;
                this.command.Parameters["@observaciones"].Value = Alerta.Observaciones;
                this.command.Parameters["@emisor"].Value = Alerta.UsuarioEmisor;
                this.command.Parameters["@destinatario"].Value = Alerta.UsuarioDestinatario;
                this.command.Parameters["@id"].Value = Alerta.Id;
                this.command.Parameters["@realizada"].Value = Alerta.Realizada;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarAlerta(Alerta Alerta)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from alerta where id_alerta=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = Alerta.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO Alertas------------------------*/

        /*--------------------Catalogo de AlertaEstadoUsos-------------------------*/

        public List<AlertaEstado> getAlertaEstado()
        {
            SqlDataReader dataReader = null;
            List<AlertaEstado> AlertaEstadoUsos = new List<AlertaEstado>();
            try
            {
                string query = "Select * from alerta_estado";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    AlertaEstado edi = new AlertaEstado();
                    edi.Id = Convert.ToInt32(dataReader["id_alerta_estado"].ToString());
                    edi.Descripcion = dataReader["descripcion"].ToString();
                    AlertaEstadoUsos.Add(edi);
                }
                return AlertaEstadoUsos;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AlertaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public String getDescripcionAlertaEstado(int i)
        {
            SqlDataReader dataReader = null;
            List<AlertaEstado> AlertaEstadoUsos = new List<AlertaEstado>();
            try
            {
                string query = "Select * from alerta_estado where id_alerta_estado="+i;
                string descripcion="";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    descripcion = dataReader["descripcion"].ToString();
                }
                return descripcion;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AlertaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantAlertaEstados()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from alerta_estado";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de AlertaEstado. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertAlertaEstado(AlertaEstado AlertaEstado)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into alerta_estado(Descripcion) values(@descripcion);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters["@descripcion"].Value = AlertaEstado.Descripcion;
                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarAlertaEstado(AlertaEstado AlertaEstado)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update alerta_estado set descripcion=@descripcion where id_alerta_estado=@id;";
                this.command.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@descripcion"].Value = AlertaEstado.Descripcion;
                this.command.Parameters["@id"].Value = AlertaEstado.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarAlertaEstado(AlertaEstado AlertaEstado)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from alerta_estado where id_alerta_estado=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = AlertaEstado.Id;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }


        /*--------------------FIN CATALOGO AlertaEstados------------------------*/

        /*--------------------Catalogo de Usuarios-------------------------*/

        public List<Usuario> getUsuario()
        {
            SqlDataReader dataReader = null;
            List<Usuario> UsuarioUsos = new List<Usuario>();
            try
            {
                string query = "Select * from usuario";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader["cod_usua"].ToString());
                    String nombre = dataReader["nombre"].ToString();
                    Boolean active = Convert.ToBoolean(dataReader["activo"].ToString());
                    Usuario usuario = new Usuario(id,nombre,active);      
                    usuario.Email=dataReader["email"].ToString();
                    usuario.Telefono=dataReader["telf"].ToString();
                    usuario.Admin=Convert.ToBoolean(dataReader["admin"]);
                    usuario.User = dataReader["usuario"].ToString();
                    usuario.Password = dataReader["password"].ToString();
                    UsuarioUsos.Add(usuario);
                }
                return UsuarioUsos;
            }
            catch (Exception e)
            {
                return null;
                //throw new Exception("Error al obtener datos de Usuario. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public int cantUsuarios()
        {
            int cantidad;
            try
            {
                string query = "Select count(*) from usuario";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                cantidad = (Int32)command.ExecuteScalar();
                return cantidad;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Usuario. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }

        public Boolean insertUsuario(Usuario Usuario,String password)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into usuario(nombre,email,telf,admin,usuario,password,activo) values(@nombre,@email,@telefono,@admin,@usuario,@password,@activo);" + "SELECT CAST(scope_identity() AS int)";
                this.command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@telefono", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@admin", SqlDbType.Bit));
                this.command.Parameters.Add(new SqlParameter("@usuario", SqlDbType.NVarChar, 30));
                this.command.Parameters.Add(new SqlParameter("@activo", SqlDbType.Bit));
                this.command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 28));

                this.command.Parameters["@nombre"].Value = Usuario.Nombre;
                this.command.Parameters["@email"].Value = Usuario.Email;
                this.command.Parameters["@telefono"].Value = Usuario.Telefono;
                this.command.Parameters["@admin"].Value = Usuario.Admin;
                this.command.Parameters["@usuario"].Value = Usuario.User;
                this.command.Parameters["@activo"].Value = Usuario.Active;
                this.command.Parameters["@password"].Value = password;

                this.lastUpdated = this.command.ExecuteScalar().ToString();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    transaction.Rollback();
                    throw new Exception("Error al insertar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al roolback accion. " + ex.Message);
                }
            }
            finally
            {
                this.connection.Close();
            }

        }

        public Boolean actualizarUsuario(Usuario Usuario)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();
            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "Update usuario set nombre=@nombre,email=@email,password=@pass,telf=@telefono,admin=@admin,usuario=@usuario,activo=@activo where cod_usua=@id;";
                this.command.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@email", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@pass", SqlDbType.NChar, 28));
                this.command.Parameters.Add(new SqlParameter("@telefono", SqlDbType.NVarChar, 50));
                this.command.Parameters.Add(new SqlParameter("@admin", SqlDbType.Bit));
                this.command.Parameters.Add(new SqlParameter("@usuario", SqlDbType.NVarChar, 30));
                this.command.Parameters.Add(new SqlParameter("@activo", SqlDbType.Bit));
                this.command.Parameters["@activo"].Value = Usuario.Active;
                this.command.Parameters["@pass"].Value = Usuario.Password;
                this.command.Parameters["@nombre"].Value = Usuario.Nombre;
                this.command.Parameters["@email"].Value = Usuario.Email;
                this.command.Parameters["@telefono"].Value = Usuario.Telefono;
                this.command.Parameters["@admin"].Value = Usuario.Admin;
                this.command.Parameters["@usuario"].Value = Usuario.User;
                this.command.Parameters["@id"].Value = Usuario.Cod_Usua;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al Actualizar." + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback accion." + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }

        public Boolean borrarUsuario(Usuario Usuario)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "delete from usuario where cod_usua=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters["@id"].Value = Usuario.Cod_Usua;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }
        public Boolean cambiarPassword(Usuario usuario,String password)
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "update usuario set password=@password where cod_usua=@id;";
                this.command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                this.command.Parameters.Add(new SqlParameter("@password", SqlDbType.NVarChar, 28));
                this.command.Parameters["@id"].Value = usuario.Cod_Usua;
                this.command.Parameters["@password"].Value = password;
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al borrar registro. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }



        /*--------------------FIN CATALOGO Usuarios------------------------*/

        /*--------------------ASIGNACIONES DE CLASS------------------------*/
        public List<AsignacionClass> getAsignacionesClass() 
        {
            SqlDataReader dataReader = null;
            List<AsignacionClass> asignaciones = new List<AsignacionClass>();
            try
            {
                string query = "select * from viewAsignacionesClass where serie not in (select descripcion collate database_default from serie)";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    String serie = dataReader["serie"].ToString();
                    AsignacionClass cl = new AsignacionClass(serie);
                    cl.AulaID = Convert.ToInt32(dataReader["id_aula"].ToString());
                    cl.Dia = dataReader["hradia"].ToString();
                    cl.HoraInicio = dataReader["hraini"].ToString();
                    cl.HoraFin = dataReader["hrafin"].ToString();
                    cl.FechaInicio = Convert.ToDateTime(dataReader["hrafdd"].ToString());
                    cl.FechaFin = Convert.ToDateTime(dataReader["hrafhh"].ToString());
                    asignaciones.Add(cl);
                }
                return asignaciones;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Usuario. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
            
        }

        //Encontrar el id de grupo en base al numero de serie
        public int getIdFromGrupo(string serie)
        {
            SqlDataReader dataReader = null;
            int idGrupo=0;
            try
            {
                string query = "Select * from grupo where serie='"+serie+"'";
                command = new SqlCommand(query, connection);
                command.Connection.Open();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    idGrupo=Convert.ToInt32(dataReader["id_grupo"].ToString());
                }
                return idGrupo;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener datos de Usuario. " + e.Message.ToString());
            }
            finally
            {
                command.Connection.Close();
            }
        }
        /*-------------------FINASIGNACIONES DE CLASS------------------------*/

        public bool insertPendingTeachers()
        {
            this.connection.Open();
            this.command = this.connection.CreateCommand();
            this.transaction = this.connection.BeginTransaction();

            this.command.Connection = this.connection;
            this.command.Transaction = this.transaction;

            try
            {
                this.command.CommandText = "insert into docente(nombre,refe) select clinam,clicun" +
                " from [CLASS].[SIGA].[viewClientes] where clitip='P' and clicun not in (select refe collate database_default from docente)";
                this.command.ExecuteNonQuery();
                this.transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                try
                {
                    this.transaction.Rollback();
                    throw new Exception("Error al actualizar profesores. " + e.Message);
                    return false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al rollback acción. " + ex.Message);
                    return false;
                }
            }
            finally
            {
                this.connection.Close();
            }
        }
        
    }
}
