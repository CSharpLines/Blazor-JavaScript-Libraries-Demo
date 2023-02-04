using JSInterpDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSInterpDemo;
public static class DatabaseContext
{
	public static List<Notification> Notifications { get; set; } = new List<Notification> { };

	public static List<Document> Documents { get; set; } = new List<Document>
	{
		new Document
		{
			Id = 1,
			Title = "Page Document 1",
			PageContent = "This is page content",
		},
		new Document
		{
			Id = 2,
			Title = "Page Document 2",
            PageContent = "This is page content",
        },
		new Document
		{
			Id = 3,
			Title = "Page Document 3",
            PageContent = "This is page content",
        },
		new Document
		{
			Id = 4,
			Title = "Page Document 4",
            PageContent = "This is page content",
        },
		new Document
		{
			Id = 5,
			Title = "Page Document 5",
            PageContent = "This is page content",
        },
	};
}