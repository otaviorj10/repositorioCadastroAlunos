using AlunoApp.FileContext;
using AlunoApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApp.Controllers
{
    public class MainController : Controller
    {

        private readonly AlunoAppContext contexto;

        public MainController(AlunoAppContext contexto)
        {
            this.contexto = contexto;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Cadastrar(AlunoModel aluno)
        {
            if (ModelState.IsValid)
            {
                contexto.Add(aluno);
                contexto.SaveChanges();

            }
            return RedirectToAction("Consultar");



        }


        public IActionResult Consultar()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Consultar(int id)
        {


            AlunoModel aluno = contexto.Aluno.Find(id);
            return RedirectToAction("AmostrarResultado", aluno);



        }

        public IActionResult AmostrarResultado(AlunoModel model)
        {
            return View(model);
        }




        public IActionResult ExcluirAlunos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExcluirAlunos(int id)
        {
            AlunoModel aluno = contexto.Aluno.Find(id);

            if ((contexto.Aluno.Find(id) == null))
            {
                RedirectToAction("Consultar");


            } else 
            {
                contexto.Remove(aluno);
                contexto.SaveChanges();
                return RedirectToAction("Cadastrar");

            }


            return View();
            
            
        }


        public IActionResult Update()
        {
            {
                return View();
            }

        }


        [HttpPost]
        public IActionResult Update(AlunoModel aluno, int? id)
        {

                var alunos = contexto.Aluno.Where(p => p.AlunoId == aluno.AlunoId).FirstOrDefault();
                AlunoModel alun = new();
                alunos.DataDeNascimento = aluno.DataDeNascimento;
                alunos.Matricula = aluno.Matricula;
                alunos.Nome = aluno.Nome;
                contexto.Update(alunos);
                contexto.SaveChanges();

            return RedirectToAction("Consultar");
        }




    }
}
