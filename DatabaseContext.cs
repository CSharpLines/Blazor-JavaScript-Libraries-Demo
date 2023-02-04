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
}