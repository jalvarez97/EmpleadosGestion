using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EmpleadosGestion.Modelos;

namespace EmpleadosGestion.Controladores
{
    public class CtrlJob : ConexionBBDD
    {
        public CtrlJob() { }

        public List<Job> GetAllJobs(string orden)
        {
            List<Job> lstJobs = new List<Job>();
            SqlDataReader reader;            
            string commandText;
            
            commandText = @"SELECT [job_id],[job_title],[min_salary],[max_salary]
                            FROM[dbo].[jobs] ORDER BY[job_id] " + orden;

            using (SqlConnection conexionBD = base.Conexion())
            {
                SqlCommand command = new SqlCommand(commandText, conexionBD);

                try
                {
                    conexionBD.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Job oJob = new Job();
                        oJob.job_id = reader.GetInt32(0);
                        oJob.job_title = reader.GetString(1);
                        oJob.min_salary = reader.GetDecimal(2);
                        oJob.max_salary = reader.GetDecimal(3);
                        lstJobs.Add(oJob);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

            }     
            
            return lstJobs;
        }

        public List<Job> GetJobById(int nId)
        {
            SqlDataReader reader;
            List<Job> lstJobs = new List<Job>();
            string commandText;

            commandText = @"SELECT [job_id],[job_title],[min_salary],[max_salary]
                            FROM[dbo].[jobs]
                            WHERE [job_id] = @job_id ";
                
            using (SqlConnection conexionBD = base.Conexion())
            {
                SqlCommand command = new SqlCommand(commandText, conexionBD);
                command.Parameters.Add("@job_id", SqlDbType.Int);
                command.Parameters["@job_id"].Value = nId;

                try
                {
                    conexionBD.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Job oJob = new Job();
                        oJob.job_id = reader.GetInt32(0);
                        oJob.job_title = reader.GetString(1);
                        oJob.min_salary = reader.GetDecimal(2);
                        oJob.max_salary = reader.GetDecimal(3);
                        lstJobs.Add(oJob);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }             
            
           return lstJobs;
        }

        public List<Job> GetJobByTitle(string sTitle)
        {
            SqlDataReader reader;
            List<Job> lstJobs = new List<Job>();
            string commandText;

            commandText = @"SELECT [job_id],[job_title],[min_salary],[max_salary]
                            FROM[dbo].[jobs]
                            WHERE [job_title] LIKE @job_title ";

            using (SqlConnection conexionBD = base.Conexion())
            {
                SqlCommand command = new SqlCommand(commandText, conexionBD);
                command.Parameters.Add("@job_title", SqlDbType.VarChar);
                command.Parameters["@job_title"].Value = "%" + sTitle + "%";

                try
                {
                    conexionBD.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Job oJob = new Job();
                        oJob.job_id = reader.GetInt32(0);
                        oJob.job_title = reader.GetString(1);
                        oJob.min_salary = reader.GetDecimal(2);
                        oJob.max_salary = reader.GetDecimal(3);
                        lstJobs.Add(oJob);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

            return lstJobs;
        }

        public List<Job> GetJobBySalaryMin(decimal nSalaryMin)
        {
            SqlDataReader reader;
            List<Job> lstJobs = new List<Job>();
            string commandText;

            commandText = @"SELECT [job_id],[job_title],[min_salary],[max_salary]
                            FROM[dbo].[jobs]
                            WHERE [min_salary] = @min_salary";

            using (SqlConnection conexionBD = base.Conexion())
            {
                SqlCommand command = new SqlCommand(commandText, conexionBD);
                command.Parameters.Add("@min_salary", SqlDbType.Decimal);
                command.Parameters["@min_salary"].Value = nSalaryMin;

                try
                {
                    conexionBD.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Job oJob = new Job();
                        oJob.job_id = reader.GetInt32(0);
                        oJob.job_title = reader.GetString(1);
                        oJob.min_salary = reader.GetDecimal(2);
                        oJob.max_salary = reader.GetDecimal(3);
                        lstJobs.Add(oJob);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

            return lstJobs;
        }

        public List<Job> GetJobBySalaryMax(decimal nSalaryMax)
        {
            SqlDataReader reader;
            List<Job> lstJobs = new List<Job>();
            string commandText;

            commandText = @"SELECT [job_id],[job_title],[min_salary],[max_salary]
                            FROM[dbo].[jobs]
                            WHERE [max_salary] = @max_salary";

            using (SqlConnection conexionBD = base.Conexion())
            {
                SqlCommand command = new SqlCommand(commandText, conexionBD);
                command.Parameters.Add("@max_salary", SqlDbType.Decimal);
                command.Parameters["@max_salary"].Value = nSalaryMax;

                try
                {
                    conexionBD.Open();

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Job oJob = new Job();
                        oJob.job_id = reader.GetInt32(0);
                        oJob.job_title = reader.GetString(1);
                        oJob.min_salary = reader.GetDecimal(2);
                        oJob.max_salary = reader.GetDecimal(3);
                        lstJobs.Add(oJob);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }

            return lstJobs;
        }
        
        public void InsertJob(Job oJob)
        {
            string commandText = @"INSERT INTO jobs (job_title, min_salary, max_salary) 
                               VALUES (@job_title, @min_salary, @max_salary)";

            using (SqlConnection con = base.Conexion())
            {
                SqlCommand command = new SqlCommand(commandText, con);

                command.Parameters.Add("@job_title", SqlDbType.VarChar);
                command.Parameters["@job_title"].Value = oJob.job_title;

                command.Parameters.Add("@min_salary", SqlDbType.Decimal);
                command.Parameters["@min_salary"].Value = oJob.min_salary;

                command.Parameters.Add("@max_salary", SqlDbType.Decimal);
                command.Parameters["@max_salary"].Value = oJob.max_salary;

                try
                {
                    con.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Se ha generado un nuevo puesto de trabajo", "Exito", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        public void UpdateJob(Job oJob)
        {
            string commandText = @"UPDATE jobs 
                                   SET job_title = @job_title, min_salary = @min_salary
                                                 , max_salary =  @max_salary
                                   WHERE job_id = @job_id";

            using (SqlConnection con = base.Conexion())
            {
                SqlCommand command = new SqlCommand(commandText, con);

                command.Parameters.Add("@job_id", SqlDbType.Int);
                command.Parameters["@job_id"].Value = oJob.job_id;

                command.Parameters.Add("@job_title", SqlDbType.VarChar);
                command.Parameters["@job_title"].Value = oJob.job_title;

                command.Parameters.Add("@min_salary", SqlDbType.Decimal);
                command.Parameters["@min_salary"].Value = oJob.min_salary;

                command.Parameters.Add("@max_salary", SqlDbType.Decimal);
                command.Parameters["@max_salary"].Value = oJob.max_salary;

                try
                {
                    con.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Se ha modificado un puesto de trabajo", "Exito", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        public void DeleteJob(Job oJob)
        {
            string commandText = @"Delete jobs 
                                   WHERE job_id = @job_id";

            using (SqlConnection con = base.Conexion())
            {
                SqlCommand command = new SqlCommand(commandText, con);

                command.Parameters.Add("@job_id", SqlDbType.Int);
                command.Parameters["@job_id"].Value = oJob.job_id;

                try
                {
                    con.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        MessageBox.Show("Se ha eliminado un puesto de trabajo", "Exito", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

    }
}
