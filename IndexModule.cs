namespace StartingPoint
{
	using Nancy;

	public class IndexModule : NancyModule
	{
		public IndexModule ()
		{
			Get ["/"] = parameters => {
				return "Hello World!";
			};
		}
	}
}