using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VilleNamespace
{
    enum StatutBatiment
    {
        parfait,
        necessite_Une_reparation,
        doit_etre_demoli,
        besoinDeResource
    }

    internal class Batiment
    {
        public string Coordonnee { get; set; }
        public StatutBatiment StatutBatiment { get; set; }
        public int QuantiteDeRessource { get; set; }
        public int Priorite { get; set; }

        public Batiment() 
        {
            Coordonnee = "";
            StatutBatiment = StatutBatiment.necessite_Une_reparation;
            QuantiteDeRessource = 500;
            Priorite = 7;
        }

        public Batiment(int priorite)
        {
            Coordonnee = "";
            StatutBatiment = StatutBatiment.necessite_Une_reparation;
            QuantiteDeRessource = 500;
            Priorite = priorite;
        }

        public Batiment(StatutBatiment statutBatiment, int priorite) 
        {
            Coordonnee = "3869 la lorelle";
            StatutBatiment = statutBatiment;
            QuantiteDeRessource = 400;
            Priorite = priorite;
        }

        public Batiment(StatutBatiment statutBatiment, int priorite, int quantiteDeRessource = 600, string coordonnee = "3869 la lorelle")
        {
            Coordonnee = coordonnee;
            StatutBatiment = statutBatiment;
            QuantiteDeRessource = quantiteDeRessource;
            Priorite = priorite;
        }

        public override string ToString() 
        {
            return $"statut : {StatutBatiment}, quantite de resouce : {QuantiteDeRessource}, priorite :{Priorite}";
        }
    }
}
