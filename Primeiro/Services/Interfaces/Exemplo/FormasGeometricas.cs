using System;
using Primeiro.Services.Interfaces.Exemplo.Entities;
using Primeiro.Services.Interfaces.Exemplo.Enums;

namespace Primeiro.Services.Interfaces.Exemplo
{
    public class FormasGeometricas
    {
        public void FormasGeo(){
         IShape s1 = new Circle() {Radius = 2.0, Color = Color.White};
         IShape s2 = new Rectangle() {Width=3.5, Height= 4.2, Color = Color.Black};
         Console.WriteLine(s1);
         Console.WriteLine(s2);
        }
    }
}