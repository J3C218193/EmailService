﻿using API.Models;

namespace API.DTOs.Educations
{
    public class CreateEducationDto
    {
        public string Major { get; set; }
        public string Degree { get; set; }
        public float Gpa { get; set; }
        public Guid UniversityGuid { get; set; }
        

        public static implicit operator Education(CreateEducationDto createEducationDto)
        {
            return new Education
            {
                Guid = new Guid(),
                Major = createEducationDto.Major,
                Degree = createEducationDto.Degree,
                GPA = createEducationDto.Gpa,
                UniversityGuid = createEducationDto.UniversityGuid,
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now

            };
        }
  
    }
}
