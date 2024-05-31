﻿using System.ComponentModel.DataAnnotations;

namespace FormContato.DTOs;

public class ContactDTO
{
    [Required]
    public string? Nome { get; set; }

    [Required]
    public string? Email { get; set; }

    [Required]
    public string? Mensagem { get; set; }

}