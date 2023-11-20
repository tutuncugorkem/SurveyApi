﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SurveyApi.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore] //clienta ekstradan status kod donmemek için
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }

        public static CustomResponseDto<T> Success(int statusCode ,T data)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Data = data };
        }
        public static CustomResponseDto<T> Success(int statusCode) 
        { 
            return new CustomResponseDto<T> {StatusCode = statusCode }; 
        }
        public static CustomResponseDto<T> Fail(int statusCode, List<string> errors) 
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = errors };
        }
        public static CustomResponseDto<T> Fail(int statusCode, string error)
        {
            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error} };
        }
    }
}
//static factory method