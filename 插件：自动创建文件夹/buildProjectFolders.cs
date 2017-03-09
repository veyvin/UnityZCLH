using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class buildProjectFolders : ScriptableWizard
{

    public bool IncludeResourceFolder = false;
    public bool UseNamespace = false;
    private string SFGUID;
    public List<string> nsFolders = new List<string>();
    public List<string> folders = new List<string>() { "StreamingAssets","Scenes", "Scripts", "Animation", "Audio", "Materials", "Meshes", "Prefabs", "Artwork", "Textures", "Sprites","Editor","Plugins" };
    [MenuItem("Edit/Create Project Folders...")]
    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard("Create Project Folders", typeof(buildProjectFolders), "Create");
    }

    //Called when the window first appears
    void OnEnable()
    {

    }
    //Create button click
    void OnWizardCreate()
    {

        //create all the folders required in a project
        //primary and sub folders
        foreach (string folder in folders)
        {
            string guid = AssetDatabase.CreateFolder("Assets", folder);
            string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);
            if (folder == "Plugins")
                SFGUID = newFolderPath;
        }

        AssetDatabase.Refresh();
        if (UseNamespace == true)
        {
            foreach (string nsf in nsFolders)
            {
                //AssetDatabase.Contain
                string guid = AssetDatabase.CreateFolder("Assets/Plugins", nsf);
                string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

            }
        }
    }
    //Runs whenever something changes in the editor window...
    void OnWizardUpdate()
    {
        if (IncludeResourceFolder == true && !folders.Contains("Resources"))
            folders.Add("Resources");
        if (IncludeResourceFolder == false && folders.Contains("Resources"))
            folders.Remove("Resources");

        if (UseNamespace == true)
            addNamespaceFolders();
        if (UseNamespace == false)
            removeNamespceFolders();

    }
    void addNamespaceFolders()
    {


        if (!nsFolders.Contains("x86"))
            nsFolders.Add("x86");

        if (!nsFolders.Contains("x86_64"))
            nsFolders.Add("x86_64");


        if (!nsFolders.Contains("Android"))
            nsFolders.Add("Android");

        if (!nsFolders.Contains("ios"))
            nsFolders.Add("ios");

        // (nsFolders);
    }

    void removeNamespceFolders()
    {
        if (nsFolders.Count > 0) nsFolders.Clear();
    }
}