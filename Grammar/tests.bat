java -jar grammatica-1.6.jar language.grammar --debug 
java -jar grammatica-1.6.jar language.grammar --tokenize test.def > test.txt
java -jar grammatica-1.6.jar language.grammar --parse test.def > test.txt
pause