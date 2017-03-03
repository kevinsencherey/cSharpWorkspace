Kevin Sencherey

----- Part 1 -----

The regular expression provided did not validate the post codes properly.
I therefore replaced it with a different one obtained online from regexlib.com. 
The expression thus provided has been commented out in the code
 
	
----- Part 2 and Part 3 -----

The PostCodeValidator method is used to validate the post codes in the import_data csv file.
The CsvSorter sort out the data in the csv files in ascending order.	

CsvSorter() replaces the failed_validation and succeeded_validation csv files instead of creating new
	ones in order to save space each time the program is run.