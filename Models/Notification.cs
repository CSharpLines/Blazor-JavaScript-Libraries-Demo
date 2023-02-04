using JSInterpDemo.JavascriptComponents.Noty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSInterpDemo.Models;
public class Notification
{
	public string Text { get; set; }
	public DateTime? DateShown { get; set; }
	public NotyAlertType Type { get; set; }
}