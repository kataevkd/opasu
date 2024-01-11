using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace RESTfull.API
{

	public class PublicationDto
	{
        public Guid Id { get; set; }
        public string PublicationName { get; set; } = String.Empty;
        public string PublicationTheme { get; set; } = String.Empty;
        public string PublicationDate { get; set; } = String.Empty;
    }
}
