using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Jarvis
{
    class Jarvis_
    {
        class Arms
        {
            public ulong ArmsEnergy { get; set; }
            public int ReachDistance { get; set; }
            public int FingersCount { get; set; }

            public override string ToString()
            {
                string result = string.Empty;
                result += string.Format($"#Arm:\r\n");
                result += string.Format($"###Energy consumption: {ArmsEnergy}\r\n");
                result += string.Format($"###Reach: {ReachDistance}\r\n");
                result += string.Format($"###Fingers: {FingersCount}\r\n");
                return result;
            }
        }
        class Legs
        {
            public ulong Energy { get; set; }
            public int Strength { get; set; }
            public int Speed { get; set; }

            public override string ToString()
            {
                string result = string.Empty;
                result += "#Leg:\r\n";
                result += "###Energy consumption: " + Energy + "\r\n";
                result += "###Strength: " + Strength + "\r\n";
                result += string.Format($"###Speed: {Speed}\r\n");

                return result;
            }
        }
        class Torso
        {
            public ulong TorsoEnergy { get; set; }
            public double  ProcessorSize { get; set; }
            public string  Material { get; set; }

            public override string ToString()
            {
                string result = string.Empty;
                result += string.Format($"#Torso:\r\n");
                result += string.Format($"###Energy consumption: {TorsoEnergy}\r\n");
                result += string.Format($"###Processor size: {ProcessorSize}\r\n");
                result += string.Format($"###Corpus material: {Material}\r\n");
                return result;
            }
        }
        class Head
        {
            public ulong HeadEnergy { get; set; }
            public int IQ { get; set; }
            public string SkinMaterial { get; set; }
            public override string ToString()
            {
                string result = string.Empty;
                result += string.Format($"#Head:\r\n");
                result += string.Format($"###Energy consumption: {HeadEnergy}\r\n");
                result += string.Format($"###IQ: {IQ}\r\n");
                result += string.Format($"###Skin material: {SkinMaterial}\r\n");
                return result;
            }
        }
        class Jarvis
        {
            public ulong Energy { get; set; }
            public Head Head { get; set; }
            public Torso Torso { get; set; }
            public List<Arms> Arms { get; set; }
            public List<Legs> Legs { get; set; }

            public void AddHead(Head headInput)
            {
                if (headInput.HeadEnergy < Head.HeadEnergy)
                {
                    Head = headInput;
                }
            }
            public void AddTorso(Torso torsoInput)
            {
                if (torsoInput.TorsoEnergy < Torso.TorsoEnergy)
                {
                    Torso = torsoInput;
                }
            }

            public void AddArm(Arms arm)
            {
                if (Arms == null)
                {
                    Arms = new List<Arms>();
                }
                if (Arms.Count < 2)
                {
                    Arms.Add(arm);
                }
                else
                {
                    for (int i = 0; i < Arms.Count; i++)
                    {
                        if (Arms[i].ArmsEnergy > arm.ArmsEnergy)
                        {
                            Arms.RemoveAt(i);
                            Arms.Add(arm);
                        }
                    }
                }
            }
            public void AddLeg(Legs leg)
            {
                if (Legs == null)
                {
                    Legs = new List<Legs>();
                }
                if (Legs.Count < 2)
                {
                    Legs.Add(leg);
                }
                else
                {
                    for (int i = 0; i < Legs.Count; i++)
                    {
                        if (Legs[i].Energy > leg.Energy)
                        {
                            Legs.RemoveAt(i);
                            Legs.Add(leg);
                        }
                    }
                }
            }
            public override string ToString()
            {
                if (Head == null || Torso == null || Arms.Count < 2 || Legs.Count < 2)
                {
                    return "We need more parts!"; 
                }
                ulong totalEnergy = 0L;
                totalEnergy += Head.HeadEnergy;
                totalEnergy += Torso.TorsoEnergy;
                totalEnergy += Arms.Select(a => a.ArmsEnergy).Sum();
                totalEnergy += Legs.Select(a => a.Energy).Sum();

                if (totalEnergy > Energy)
                {
                    return "We need more power!";
                }

                StringBuilder sb = new StringBuilder();
                sb.Append("Jarvis:\r\n");
                sb.Append(Head.ToString());
                sb.Append(Torso.ToString());
                foreach (Arms arm in Arms.OrderBy(a => a.ArmsEnergy))
                {
                    sb.Append(arm.ToString());
                }
                foreach (Legs leg in Legs.OrderBy(a => a.Energy))
                {
                    sb.Append(leg.ToString());
                }
                return base.ToString();
            }
        }
        static void Main()
        {
            int jarvisEnergy = int.Parse(Console.ReadLine());
            Jarvis jarvis = new Jarvis();
            jarvis.Energy = jarvisEnergy;

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                if (tokens[0] == "Assemble!")
                {
                    break;
                }
                switch (tokens[0])
                {
                    case "Head":
                        Head head = new Head()
                        {
                            HeadEnergy = int.Parse(tokens[1]),
                            IQ = int.Parse(tokens[2]),

                        }
                }
            }
        }
    }
}
