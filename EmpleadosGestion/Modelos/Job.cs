namespace EmpleadosGestion.Modelos
{
    public class Job
    {
        public int job_id { get; set; }
        public string job_title { get; set; }
        public decimal min_salary { get; set; }
        public decimal max_salary { get; set; }

        public Job() { }

        public Job (int nJob_id, string sJob_title, decimal nMin_salary, decimal nMax_salary)
        {
            this.job_id = nJob_id;
            this.job_title = sJob_title;
            this.min_salary = nMin_salary;
            this.max_salary = nMax_salary;
        }
      
    }
}
