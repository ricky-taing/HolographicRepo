using UnityEngine;
using UnityEditor;
using System.IO;

public class CardAutoGenerator
{
    private static string cardDataCSVLocation = "/Editor/CardGenerator/card_csv_file.csv";
    [MenuItem("HoloGraphic/Generate Cards")]
    public static void GenerateCard()
    {
        string[] linesInCSVFile = File.ReadAllLines(Application.dataPath + cardDataCSVLocation);
        AlphanumericConverter alphanumericConverter = new AlphanumericConverter();
        foreach(string line in linesInCSVFile)
        {
            string[] parsedLine = line.Split(',');
            //Debug.Log(line);
            if (parsedLine.Length >= 10)
            {
                switch (parsedLine[1].ToLower())
                {
                    case "delete":
                        {
                            DeleteCard deleteCard = ScriptableObject.CreateInstance<DeleteCard>();
                            deleteCard.createDeleteCard(parsedLine[1], parsedLine[8]);
                            AssetDatabase.CreateAsset(deleteCard, $"Assets/CardSOs/{deleteCard.getCardName()}.asset");
                            break;
                        }
                    case "boost":
                        {
                            BoostCard boostCard = ScriptableObject.CreateInstance<BoostCard>();
                            boostCard.createBoostCard(parsedLine[1], int.Parse(parsedLine[2]), int.Parse(parsedLine[3]), int.Parse(parsedLine[4]),  alphanumericConverter.alphanumericToNumeric(parsedLine[5]), alphanumericConverter.alphanumericToNumeric(parsedLine[6]), int.Parse(parsedLine[7]), parsedLine[8], parsedLine[9]);
                            AssetDatabase.CreateAsset(boostCard, $"Assets/CardSOs/{boostCard.getCardName()}.asset");
                            break;
                        }
                    case "repair":
                        {
                            RepairCard repairCard = ScriptableObject.CreateInstance<RepairCard>();
                            repairCard.createRepairCard(parsedLine[1], int.Parse(parsedLine[2]), int.Parse(parsedLine[3]), int.Parse(parsedLine[4]), alphanumericConverter.alphanumericToNumeric(parsedLine[5]), alphanumericConverter.alphanumericToNumeric(parsedLine[6]), int.Parse(parsedLine[7]), parsedLine[8], parsedLine[9]);
                            AssetDatabase.CreateAsset(repairCard, $"Assets/CardSOs/{repairCard.getCardName()}.asset");
                            break;
                        }
                    case "infect":
                        {
                            InfectCard infectCard = ScriptableObject.CreateInstance<InfectCard>();
                            infectCard.createInfectCard(parsedLine[1], int.Parse(parsedLine[2]), int.Parse(parsedLine[3]), int.Parse(parsedLine[4]), alphanumericConverter.alphanumericToNumeric(parsedLine[5]), alphanumericConverter.alphanumericToNumeric(parsedLine[6]), int.Parse(parsedLine[7]), parsedLine[8], parsedLine[9]);
                            AssetDatabase.CreateAsset(infectCard, $"Assets/CardSOs/{infectCard.getCardName()}.asset");
                            break;
                        }
                    case "direct":
                        {
                            DirectCard directCard = ScriptableObject.CreateInstance<DirectCard>();
                            directCard.createDirectCard(parsedLine[1], int.Parse(parsedLine[2]), int.Parse(parsedLine[3]), int.Parse(parsedLine[4]), alphanumericConverter.alphanumericToNumeric(parsedLine[5]), alphanumericConverter.alphanumericToNumeric(parsedLine[6]), int.Parse(parsedLine[7]), parsedLine[8], parsedLine[9]);
                            AssetDatabase.CreateAsset(directCard, $"Assets/CardSOs/{directCard.getCardName()}.asset");
                            break;
                        }
                    case "extract":
                        {
                            ExtractCard extractCard = ScriptableObject.CreateInstance<ExtractCard>();
                            extractCard.createExtractCard(parsedLine[1], int.Parse(parsedLine[2]), int.Parse(parsedLine[3]), int.Parse(parsedLine[4]), alphanumericConverter.alphanumericToNumeric(parsedLine[5]), alphanumericConverter.alphanumericToNumeric(parsedLine[6]), int.Parse(parsedLine[7]), parsedLine[8], parsedLine[9]);
                            AssetDatabase.CreateAsset(extractCard, $"Assets/CardSOs/{extractCard.getCardName()}.asset");
                            break;
                        }
                }
            }
            else
                Debug.LogError("csv data file incompatible; check number of columns");
        }
        AssetDatabase.SaveAssets();
    }
}
