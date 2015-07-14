namespace Blog.Models
{
    using System;
    using System.Collections.Generic;

    public class BlogPost
    {
            public BlogPost()
            {
                    this.Comments = new HashSet<Comments>();

            }
    
            public int Id { get; set; }
            public System.DateTimeOffset Created { get; set; }
            public Nullable<System.DateTimeOfffset> Updated { get; set; }
            public string Title {get; set; }
            public string Slug { get; set; }
}


public class Class1
{
	public Class1()
	{
	}
}
