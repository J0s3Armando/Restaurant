namespace Restaurant.API.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string Address { get; set; } = null!;
        public string Telephone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Idrol { get; set; }
        public string? Rol { get; set; }
        public string PostalCode { get; set; } = null!;
        public int Idcountry { get; set; }
        public string? Country { get; set; }
        public int Idstate { get; set; }
        public string? State { get; set; }
        public Stream? PhotoFile {get; set; } 
        public string? Photo { get; set; }
        public string? Urlphoto { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
