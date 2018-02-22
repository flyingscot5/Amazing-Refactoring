String Templater

A performance kata as demonstrated by Corey Haines
http://blog.envylabs.com/2009/08/corey-haines-performance-kata/

The idea of this Kata is to go through the tests case below again and again trying different techniques

Acceptance Criteria
-------------------
StringTemplater with no tokens
returns blank string if given string is blank
returns non-blank string unchanged

StringTemplater with one token
replaces token with empty string if no value in context
replaces token with value from context
leaves the rest of the string unchanged

StringTemplater with two tokens
replaces each token with the value from the context
replaces with blank string the tokens that have no value in context
replaces tokens that are adjacent