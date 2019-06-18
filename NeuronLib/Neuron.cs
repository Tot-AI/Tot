using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace NeuronLib
{
    [DataContract]
    public class Neuron
    {
        [DataMember]
        public Point3D Name { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public double Signal { get; set; }
        [DataMember]
        public int Symbol { get; set; }
        public Neuron(Point3D input)
        {
            Name = new Point3D(input);
        }
        public void Save(double inputSignal, int inputSymbol)
        {

        }
    }
}