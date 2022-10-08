

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace aspLogin.Models;

[Table("usuario")]
public class UserModel 
{
    [Key]
    [Required]
    [Column("idUsuario")]
    public int IdUser {get;set;}

    [Column("clave")]
    [Required]
    public byte[] Password {get;set;}

    [Column("correo")]
    [Required]
    public string Email {get;set;}

    [Column("salt")]
    public string Salt {get;set;}

    [Column("nombre")]
    [Required]
    public string Name {get;set;}

    [Column("tipo")]
    public string Type {get;set;}
}