namespace School
{
    using System;

    public class Teachers : People
    {
        private Disciplines[] disciplines { get;  set; }

        public Teachers(string name, Disciplines[] disciplines)
            : base(name)
        {
            this.disciplines = disciplines;
        }
    }
}
