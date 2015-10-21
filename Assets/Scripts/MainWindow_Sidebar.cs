using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWindow_Sidebar : MonoBehaviour {

//	// Use this for initialization
//	void Start () {
//	
//	}
//	
//	// Update is called once per frame
//	void Update () {
//	
//	}

//	DirectoryInfo levelDirectoryPath = new DirectoryInfo(Application.dataPath);

	void Start() 
	{
//		foreach(string path in args) 
//		{
//			if(File.Exists(path)) 
//			{
//				// This path is a file
//				ProcessFile(path); 
//			}               
//			else if(Directory.Exists(path)) 
//			{
//				// This path is a directory
//				ProcessDirectory(path);
//			}
//			else 
//			{
//				Debug.Log("{0} is not a valid file or directory.", path);
//			}        
//		}        

//		string info = new DirectoryInfo();
//		string fileInfo = info.GetFiles();
//		foreach (string file in fileInfo) 
//			Debug.Log(file);
		DirectoryInfo dir = new DirectoryInfo(@"../");
		FileInfo[] info = dir.GetFiles("*.*");
		foreach (FileInfo f in info) 
			Debug.Log(f);

//		DirectoryInfo levelDirectoryPath = new DirectoryInfo(Application.dataPath);

//		Debug.Log (Resources.FindObjectsOfTypeAll(typeof(Directory)).Length);
//		FileInfo[] fileInfo = levelDirectoryPath.GetFiles ("*.*", SearchOption.AllDirectories);
//		foreach(FileInfo file in fileInfo)
//			Debug.Log("file: " + file);

//		Debug.Log (Resources.Load("MeccanoBuild", typeof(Directory)));

		System.IO.DirectoryInfo dir2 = new System.IO.DirectoryInfo(Application.dataPath + "/Resources/MeccanoBuild");
		int count = dir2.GetFiles().Length;
		Debug.Log ("Count: " + count); //couunt main elements
		FileInfo[] info2 = dir2.GetFiles("*.*");
		foreach (FileInfo f2 in info2) 
		{
			Debug.Log ("Files: " + f2.Name); //name of the main element

		}
	}

 	public void MakeButton(string buttonName)
	{
		GameObject menuButtons = new GameObject ();
		menuButtons.GetComponent<Canvas> ();

	}

//	public static bool PathIsDirectory (string absolutePath)
//	{
//		FileAttributes attr = File.GetAttributes(absolutePath);
//		if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
//			return true;
//		else
//			return false;
//	}
//
//	public static string AssetsRelativePath (string absolutePath)
//	{
//		if (absolutePath.StartsWith(Application.dataPath)) {
//			return "Assets" + absolutePath.Substring(Application.dataPath.Length);
//		}
//		else {
//			throw new System.ArgumentException("Full path does not contain the current project's Assets folder", "absolutePath");
//		}
//	}

//	public static string[] GetResourcesDirectories ()
//	{
//		List<string> result = new List<string>();
//		Stack<string> stack = new Stack<string>();
//		// Add the root directory to the stack
//		stack.Push(Application.dataPath);
//		// While we have directories to process...
//		while (stack.Count > 0) {
//			// Grab a directory off the stack
//			string currentDir = stack.Pop();
//			try {
//				foreach (string dir in Directory.GetDirectories(currentDir)) {
//					if (Path.GetFileName(dir).Equals("Resources")) {
//						// If one of the found directories is a Resources dir, add it to the result
//						result.Add(dir);
//					}
//					// Add directories at the current level into the stack
//					stack.Push(dir);
//				}
//			}
//			catch {
//				Debug.LogError("Directory " + currentDir + " couldn't be read from.");
//			}
//		}
//		return result.ToArray();
//	}

	// Process all files in the directory passed in, recurse on any directories 
	// that are found, and process the files they contain.
//	public static void ProcessDirectory(string targetDirectory) 
//	{
//		// Process the list of files found in the directory.
//		string [] fileEntries = Directory.GetFiles(targetDirectory);
//		foreach(string fileName in fileEntries)
//			ProcessFile(fileName);
//		
//		// Recurse into subdirectories of this directory.
//		string [] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
//		foreach(string subdirectory in subdirectoryEntries)
//			ProcessDirectory(subdirectory);
//	}
//	
//	// Insert logic for processing found files here.
//	public static void ProcessFile(string path) 
//	{
//		Debug.Log("Processed file '{0}'.", path);	    
//	}
}
