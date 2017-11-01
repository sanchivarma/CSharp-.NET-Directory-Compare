using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DirectoryComparer.Interfaces;
using DirectoryComparer.Objects;
using DirectoryComparer.Services;
using System.IO;

namespace DirectoryComparer.Comparers
{
    public class RecursiveComparer : ITwoPassComparer
    {
        //Get a reference of main form
        private frmMain _reference;

        public RecursiveComparer(frmMain reference)
        {
            //initialize the mainform reference
            _reference = reference;
        }

        //Process and compare the Folder1(Left) files with Folder2(right) structure
        public List<CompareResult> LeftCompare(string leftFolder, string rightFolder)
        {
            List<CompareResult> _leftResults = new List<CompareResult>();

            List<string> leftFiles = DirectoryLister.GetAllFiles(leftFolder);
            List<string> rightFiles = DirectoryLister.GetAllFiles(rightFolder);

            //update the progress bar
            _reference.ReportProgress(15);

            foreach (string fileOrFolder in leftFiles)
            {
                if (fileOrFolder.IsFile())
                {
                    _leftResults.Add(ProcessFile(fileOrFolder, rightFiles, CompareDirection.Left));
                }
                else if (DirectoryComparerBaseInfo.Recursive)
                {
                    _leftResults.AddRange(ProcessFolder(fileOrFolder, rightFiles, CompareDirection.Left));
                }
            }

            _reference.ReportProgress(50);

            return _leftResults;
        }

        //rocess folders for comparison
        private List<CompareResult> ProcessFolder(string fileOrFolder, List<string> otherFiles, CompareDirection direction)
        {
            List<CompareResult> results = new List<CompareResult>();

            string dirName = '\\' + fileOrFolder.GetCurrentDir();
            string correspondingDir = otherFiles.SingleOrDefault(r => r.IsDirectory() && r.EndsWith(dirName));
            if (correspondingDir != null)
            {
                List<string> leftFiles = DirectoryLister.GetAllFiles(fileOrFolder);
                List<string> cRightFiles = DirectoryLister.GetAllFiles(correspondingDir);

                if (leftFiles.Count == 0 && cRightFiles.Count == 0)
                {
                    results.Add(ProcessEmptyDirectory(fileOrFolder, correspondingDir, direction));
                }
                else
                {
                    results.Add(ProcessNonEmptyDirectory(fileOrFolder, correspondingDir, direction));
                    foreach (string fileorFolder in leftFiles)
                    {
                        results.AddRange(ProcessByType(fileorFolder, cRightFiles, direction));
                    }
                }
            }
            else
            {
                results.Add(ProcessNonEmptyDirectory(fileOrFolder, string.Empty, direction));
                List<string> files = DirectoryLister.GetAllFiles(fileOrFolder);

                if (files.Count > 0)
                {
                    foreach (var file in files)
                    {
                        results.AddRange(ProcessByType(file, null, direction));
                    }
                }
                else
                {
                    results.Add(ProcessEmptyDirectory(fileOrFolder, string.Empty, direction));
                }
            }

            return results;
        }

        //If directory is not empty, add to results
        private CompareResult ProcessNonEmptyDirectory(string currentFolder, string correspondingFolder, CompareDirection direction)
        {
            CompareResult result = new CompareResult();
            result.FileName = currentFolder;
            result.FileExtension = string.Empty;

            if (direction == CompareDirection.Left)
            {
                result.LeftFilePath = currentFolder;
                result.RightFilePath = correspondingFolder;
                result.LeftCreatedDate = currentFolder != string.Empty ? Directory.GetCreationTime(currentFolder) : DateTime.MinValue;
                result.LeftModifiedDate = currentFolder != string.Empty ? Directory.GetLastWriteTime(currentFolder) : DateTime.MinValue;
                result.RightCreatedDate = correspondingFolder != string.Empty ? Directory.GetCreationTime(correspondingFolder) : DateTime.MinValue;
                result.RightModifiedDate = correspondingFolder != string.Empty ? Directory.GetLastWriteTime(correspondingFolder) : DateTime.MinValue;
                result.ExistsLeft = currentFolder != string.Empty;
                result.ExistsRight = correspondingFolder != string.Empty;
            }
            else
            {
                result.RightFilePath = currentFolder;
                result.LeftFilePath = correspondingFolder;
                result.RightCreatedDate = currentFolder != string.Empty ? Directory.GetCreationTime(currentFolder) : DateTime.MinValue;
                result.RightModifiedDate = currentFolder != string.Empty ? Directory.GetLastWriteTime(currentFolder) : DateTime.MinValue;
                result.LeftCreatedDate = correspondingFolder != string.Empty ? Directory.GetCreationTime(correspondingFolder) : DateTime.MinValue;
                result.LeftModifiedDate = correspondingFolder != string.Empty ? Directory.GetLastWriteTime(correspondingFolder) : DateTime.MinValue;
                result.ExistsRight = currentFolder != string.Empty;
                result.ExistsLeft = correspondingFolder != string.Empty;
            }

            result.Match = currentFolder != string.Empty && correspondingFolder != string.Empty;
            result.Compared = true;

            return result;
        }

        //If directory is empty, add to results
        private CompareResult ProcessEmptyDirectory(string currentFolder, string correspondingFolder, CompareDirection direction)
        {
            CompareResult result = new CompareResult();
            result.FileName = string.Empty;
            result.FileExtension = string.Empty;

            if (direction == CompareDirection.Left)
            {
                result.LeftFilePath = currentFolder;
                result.RightFilePath = correspondingFolder;
                result.LeftCreatedDate = currentFolder != string.Empty ? Directory.GetCreationTime(currentFolder) : DateTime.MinValue;
                result.LeftModifiedDate = currentFolder != string.Empty ? Directory.GetLastWriteTime(currentFolder) : DateTime.MinValue;
                result.RightCreatedDate = correspondingFolder != string.Empty ? Directory.GetCreationTime(correspondingFolder) : DateTime.MinValue;
                result.RightModifiedDate = correspondingFolder != string.Empty ? Directory.GetLastWriteTime(correspondingFolder) : DateTime.MinValue;
                result.ExistsLeft = currentFolder != string.Empty;
                result.ExistsRight = correspondingFolder != string.Empty;
            }
            else
            {
                result.RightFilePath = currentFolder;
                result.LeftFilePath = correspondingFolder;
                result.RightCreatedDate = currentFolder != string.Empty ? Directory.GetCreationTime(currentFolder) : DateTime.MinValue;
                result.RightModifiedDate = currentFolder != string.Empty ? Directory.GetLastWriteTime(currentFolder) : DateTime.MinValue;
                result.LeftCreatedDate = correspondingFolder != string.Empty ? Directory.GetCreationTime(correspondingFolder) : DateTime.MinValue;
                result.LeftModifiedDate = correspondingFolder != string.Empty ? Directory.GetLastWriteTime(correspondingFolder) : DateTime.MinValue;
                result.ExistsRight = currentFolder != string.Empty;
                result.ExistsLeft = correspondingFolder != string.Empty;
            }

            result.Match = currentFolder != string.Empty && correspondingFolder != string.Empty;
            result.Compared = true;

            return result;
        }

        //Process file for details
        private CompareResult ProcessFile(string fileOrFolder, List<string> otherFiles, CompareDirection direction)
        {
            string file = otherFiles.SingleOrDefault(r => r.IsFile() && r.EndsWith('\\' + fileOrFolder.GetFileName()));
            CompareResult result = file != null ? ProcessFileInternal(fileOrFolder, file, direction)
                                                : ProcessFileInternal(fileOrFolder, string.Empty, direction);
            return result;
        }

        //Process file for system details
        private CompareResult ProcessFileInternal(string fileOrFolder, string file, CompareDirection direction)
        {
            CompareResult result = new CompareResult();
            result.FileName = fileOrFolder.GetFileName();
            result.FileExtension = fileOrFolder.GetFileExtension();

            if (direction == CompareDirection.Left)
            {
                result.LeftFilePath = fileOrFolder;
                result.LeftCreatedDate = File.GetCreationTime(fileOrFolder);
                result.LeftModifiedDate = File.GetLastWriteTime(fileOrFolder);
                result.LeftHash = file != string.Empty ? MD5Hash.HashFile(fileOrFolder) : string.Empty;
                result.RightFilePath = file != string.Empty ? file : string.Empty;
                result.RightCreatedDate = file != string.Empty ? File.GetCreationTime(file) : DateTime.MinValue;
                result.RightModifiedDate = file != string.Empty ? File.GetLastWriteTime(file) : DateTime.MinValue;
                result.RightHash = file != string.Empty ? MD5Hash.HashFile(file) : string.Empty;
                result.ExistsLeft = true;
                result.ExistsRight = file != string.Empty;
            }
            else
            {
                result.RightFilePath = fileOrFolder;
                result.RightCreatedDate = File.GetCreationTime(fileOrFolder);
                result.RightModifiedDate = File.GetLastWriteTime(fileOrFolder);
                result.RightHash = file != string.Empty ? MD5Hash.HashFile(fileOrFolder) : string.Empty;
                result.LeftFilePath = file != string.Empty ? file : string.Empty;
                result.LeftCreatedDate = file != string.Empty ? File.GetCreationTime(file) : DateTime.MinValue;
                result.LeftModifiedDate = file != string.Empty ? File.GetLastWriteTime(file) : DateTime.MinValue;
                result.LeftHash = file != string.Empty ? MD5Hash.HashFile(file) : string.Empty;
                result.ExistsRight = true;
                result.ExistsLeft = file != string.Empty;
            }

            result.Match = file != string.Empty ? result.LeftHash == result.RightHash : false;
            result.Compared = true;
            result.IsFile = true;

            return result;
        }

        //Process file or folder type
        private List<CompareResult> ProcessByType(string fileOrFolder, List<string> compareItems, CompareDirection direction)
        {
            List<string> _compareItems = compareItems ?? new List<string>();
            List<CompareResult> results = new List<CompareResult>();
            if (fileOrFolder.IsFile())
            {
                results.Add(ProcessFile(fileOrFolder, _compareItems, direction));
            }
            else
            {
                results.AddRange(ProcessFolder(fileOrFolder, _compareItems, direction));
            }
            return results;
        }

        //Compare Folder2(Right) structure with Folder1(left)
        public List<CompareResult> RightCompare(string rightFolder, string leftFolder)
        {
            List<CompareResult> _rightResults = new List<CompareResult>();

            List<string> leftFiles = DirectoryLister.GetAllFiles(leftFolder);
            List<string> rightFiles = DirectoryLister.GetAllFiles(rightFolder);

            _reference.ReportProgress(70);

            foreach (string fileOrFolder in rightFiles)
            {
                if (fileOrFolder.IsFile())
                {
                    CompareResult result = ProcessFile(fileOrFolder, leftFiles, CompareDirection.Right);
                    if (IsNotPresent(result))
                        _rightResults.Add(result);
                }
                else if (DirectoryComparerBaseInfo.Recursive)
                {
                    List<CompareResult> results = ProcessFolder(fileOrFolder, leftFiles, CompareDirection.Right);
                    _rightResults.AddRange(GetRightOnly(results));
                }
            }

            _reference.ReportProgress(90);

            return _rightResults;
        }

        //Check is a file or folder only exists in Right folder
        private bool IsNotPresent(CompareResult result)
        {
            return !(result.ExistsLeft && result.ExistsRight);
        }

        //Get files and folder only present in right folder
        private List<CompareResult> GetRightOnly(List<CompareResult> results)
        {
            return results.Where(i => i.ExistsLeft != i.ExistsRight).ToList();
        }
    }
}
