using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController: ControllerBase
{
    private static List<Character> characters = new() { new Character(), new Character {Id = 1, Name = "Sam"} };
    
    [HttpGet("GetAll")]
    public ActionResult<List<Character>> Get()
    {
        return Ok(characters);
    }
    
    [HttpGet("GetSingle")]
    public ActionResult<Character> GetSingle()
    {
        return Ok(characters.First());
    }
    
    [HttpGet("GetById")]
    public ActionResult<Character> GetById(int id)
    {
        return Ok(characters.FirstOrDefault(character => character.Id == id));
    }
}