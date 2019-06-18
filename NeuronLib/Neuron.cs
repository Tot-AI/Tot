using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronLib
{
    public class Neuron
    {
        public Point3D Name { get; set; }
        public string Path { get; set; }
        public double Signal { get; set; }
        public int Symbol { get; set; }
    }
}