using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatimentNamespace
{
    enum StatutBatiment
    {
        parfait,
        necessite_retapation,
        doit_etre_demoli
    }

    internal class Batiment
    {
        public string Coordonnee { get; set; }
        public StatutBatiment StatutBatiment { get; set; }
        public int QuantiteDeRessource { get; set; }
        public int Priorite { get; set; }

        public Batiment() 
        {

        }
    }
}
