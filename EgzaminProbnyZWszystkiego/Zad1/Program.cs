namespace Konsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IEvaluatable> lista = new List<IEvaluatable>();

            Query query1 = new Query("SELECT");
            Query query2 = new Query("SELECT DISTINCT");

            lista.Add(query1);
            lista.Add(query2);

            Opinion opinion1 = new Opinion("BAD");
            Opinion opinion2 = new Opinion("GOOD");

            lista.Add(opinion1);
            lista.Add(opinion2);

            foreach (var item in lista)
            {
                Console.WriteLine(item.GetType().Name + ": " + item.CountChars() + " znaków");
            }
        }
    }

    public interface IEvaluatable
    {
        int CountChars();
    }

    public class Query(string content) : IEvaluatable
    {
        public string Content = content;
        public int CountChars()
        {
            return Content.Length;
        }
    }

    public class Opinion(string feedback) : IEvaluatable
    {
        public string Feedback = feedback;
        public int CountChars()
        {
            return Feedback.Length;
        }
    }
}
