using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entities.ErrorModel
{
	public class ErrorDetails
	{
        public int StatusCode { get; set; }
        public string? Message { get; set; } //null check
		public override string ToString()
		{
			return JsonSerializer.Serialize(this); //Serialize metodu, bir nesneyi JSON formatında bir dizeye dönüştürür(serileştirir)
		}
	}
}
