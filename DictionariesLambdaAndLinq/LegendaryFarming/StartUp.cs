using System;
using System.Linq;
using System.Collections.Generic;
public class StartUp
{
    public static void Main()
    {
        var legendaryItems = new Dictionary<string, int>();
        var junkMaterials = new Dictionary<string, int>();

        legendaryItems["shards"] = 0;
        legendaryItems["fragments"] = 0;
        legendaryItems["motes"] = 0;

        while (true)
        {
            var materials = Console.ReadLine()
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var quantity = 0;
            var material = string.Empty;
            var isEnough = false;

            for (int i = 0; i < materials.Length; i++)
            {
                if (i % 2 == 0)
                {
                    var currentQuantity = int.Parse(materials[i]);
                    quantity = currentQuantity;
                }
                else if (i % 2 != 0)
                {
                    var currentMaterial = materials[i];
                    material = currentMaterial;
                }

                if (i % 2 != 0)
                {
                    if (material == "shards")
                    {
                        legendaryItems["shards"] += quantity;

                        if (legendaryItems["shards"] >= 250)
                        {
                            legendaryItems["shards"] -= 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            isEnough = true;
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        legendaryItems["fragments"] += quantity;

                        if (legendaryItems["fragments"] >= 250)
                        {
                            legendaryItems["fragments"] -= 250;
                            Console.WriteLine("Valanyr obtained!");
                            isEnough = true;
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        legendaryItems["motes"] += quantity;

                        if (legendaryItems["motes"] >= 250)
                        {
                            legendaryItems["motes"] -= 250;
                            Console.WriteLine("Dragonwrath obtained!");
                            isEnough = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials[material] = 0;
                        }

                        junkMaterials[material] += quantity;
                    }
                }
            }

            if (isEnough)
            {
                break;
            }
        }

        PrintLegendaryItems(legendaryItems);
        PrintJunkMaterials(junkMaterials);
    }

    static void PrintJunkMaterials(Dictionary<string, int> junkMaterials)
    {
        foreach (var item in junkMaterials.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
    static void PrintLegendaryItems(Dictionary<string, int> legendaryItems)
    {
        foreach (var item in legendaryItems.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}