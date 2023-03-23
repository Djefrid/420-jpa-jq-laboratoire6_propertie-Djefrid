using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BatimentNamespace;

namespace VilleNamespace
{
    enum StatutVille
    {
        parfait,
        necessite_retapation,
        doit_etre_demoli
    }

    internal class Ville
    {
        public string Nom { get; set; }
        public StatutVille StatutVille { get; set; }
        public List<Batiment> batiments { get; set; }

        public Ville() 
        {

        }
    }
}
