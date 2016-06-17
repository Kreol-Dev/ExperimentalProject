
ROOT = (IDENTIFIER EQUALS CONTEXT)+;
SCOPE = IdOrCallOrScope (DOT IdOrCallOrScope)*;
OPERATOR = IdOrCallOrScope EQUALS CONTEXT;
CONTEXT = OPEN_TABLE OPSORATOMS CLOSE_TABLE | EXPRESSION;
OPSORATOMS = IdOrCallOrScope (OPSORATOMSTAILS)? | ATOM (ATOMORIdOrCallOrScope)*;
OPSORATOMSTAILS = (ATOMORIdOrCallOrScope)+| EQUALS CONTEXT (OPERATOR)*;

IdOrCallOrScope = IDENTIFIER (DOT IdOrCallOrScope)* ()?;

Atom = NUMBER | TRUE | FALSE | STRING;
ATOMORIdOrCallOrScope = ATOM | IdOrCallOrScope;
FACTOR = (SUB | NOT)? ATOMORIdOrCallOrScope | (SUB | NOT)? OPEN_PARENT EXPRESSION CLOSE_PARENT;
MULTTERM = FACTOR (MUL FACTOR | DIV FACTOR)*;

ADDITTERM = MULTTERM (ADD MULTTERM | SUB MULTTERM)*;

RELATTERM = ADDITTERM (MORE RELATTERM | LESS RELATTERM | MOREOREQUALS RELATTERM | LESSOREQUALS RELATTERM)*;

EQTERM = RELATTERM (EQUALS EQTERM)*;

ANDTERM = EQTERM (AND ANDTERM)*;

ORTERM = ANDTERM (OR ORTERM)*;

EXPRESSION = ORTERM;