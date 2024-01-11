using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Summary description for Class1
/// </summary>
namespace RESTfull.API.DTO
{
	public class AuthorDto
	{
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Degree { get; set; } = String.Empty;

        public string placeWork { get; set; } = String.Empty;
        public List<PublicationDto> PublicationDtos { get; set; } = new List<PublicationDto>();
        

    }
}