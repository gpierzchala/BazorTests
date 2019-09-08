namespace BazorTests.Shared.DTOs
{
    using System;

    public abstract class BaseDto
    {
        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }
    }
}
