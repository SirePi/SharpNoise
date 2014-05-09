﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexPlanetExample
{
    public partial class GeneratorSettingsForm : Form
    {
        public PlanetGenerationSettings GeneratorSettings { get; set; }

        public GeneratorSettingsForm()
        {
            InitializeComponent();

            GeneratorSettings = new PlanetGenerationSettings();
            propertyGrid.SelectedObject = GeneratorSettings;
        }
    }
}
