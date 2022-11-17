using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication5.DTOs;

namespace WebApplication5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FigureController : ControllerBase
    {
        //CRUD

        public static List<Figure> figures = new List<Figure>() { };

        //Create
        [HttpPost("Circle")]
        public IActionResult CreateCircle([FromBody] CirclePointDto pointDto)
        {
            List<Point> pointsOfCircle = new List<Point>();
            pointsOfCircle.Add(pointDto.point1);
            pointsOfCircle.Add(pointDto.point2);
            Circle circle = new Circle(pointsOfCircle);
            figures.Add(circle);
            return Ok(circle);
        }

        [HttpPost("Rectangle")]
        public IActionResult CreateRectangle([FromBody] RectanglePointDTO pointDto)
        {
            List<Point> pointsOfRectangle = new List<Point>();
            pointsOfRectangle.Add(pointDto.point1);
            pointsOfRectangle.Add(pointDto.point2);
            pointsOfRectangle.Add(pointDto.point3);
            pointsOfRectangle.Add(pointDto.point4);
            Rectangle rectangle = new Rectangle(pointsOfRectangle);
            figures.Add(rectangle);
            
            return Ok(rectangle);
        }

        //Read
        [HttpGet]
        public IActionResult GetAllFigures()
        {
            return Ok(figures);
        }

        //Update
        [HttpPut]
        public IActionResult UpdateFigure(int id, double scale)
        {
            foreach(Figure figure in figures)
            {
                if(figure.CheckID(id))
                {
                    figure.Scale(scale);
                    return Ok(figure);
                }    
            }
            return Ok();
        }

        //Delete
        [HttpDelete]
        public IActionResult DeleteFigure(int id)
        {
            foreach (Figure figure in figures)
            {
                if (figure.CheckID(id))
                {
                    figures.Remove(figure);
                }
            }
            return Ok();
        }
    }
   
}
