internal class Program
{
	static void Main(string[] args)
	{
		Student.WhoAreYou();
	}

	static class Student
	{
		static public void WhoAreYou()
		{
            Console.WriteLine("나는 학생 클래스 입니다.");
        }
	}

}