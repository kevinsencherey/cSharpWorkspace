 Kevin Sencherey

1. Load the solution (PostCodeValidation.sln)in Visual Studio. 

2. Go to PostCodeValidation.cs

3. Edit the filePath in the PostCodeBulkValidator() method of the PostCodeValidation.cs class.
   The specified path should be the folder containing the app.config file on your local machine.
	
		
4. Create two csv files (comma delimiter) call them failed_validation.csv and succeeded_validation.csv

5. Save both files together with the import_data.csv in the same folder containing the app.config file


6. Move to the CsvSorter() method in the PostCodeValidation.cs class.
   Edit the string elements of 'csvToRead' same as in step 3, making sure that
   the paths include the csv files.
		
7. Build (CTRL+SHIFT+B)the solution.
		
8. Go to Test tab and run all tests.
		
9. Run the Program.cs with (CTRL+F5)
   Console will list all postcode in Part 1, displaying valid or invalid next to them.
   Press any key to quit.
		
10. The program will then write the valid and invalid postcodes to the corresponding csv files.
    
		