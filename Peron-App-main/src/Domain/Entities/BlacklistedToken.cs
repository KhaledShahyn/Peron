﻿namespace FinalProject.src.Domain.Entities
{
    public class BlacklistedToken
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime RevokedOn { get; set; }

    }

}
