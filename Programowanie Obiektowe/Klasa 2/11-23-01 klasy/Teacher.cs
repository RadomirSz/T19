namespace _10_2_16_01
{
    class Teacher 
    {
        public List<string>? Subjects { private get; set; }
        public string GetSubjects()
        {
            return string.Join(", ", Subjects);
        }
    }
}