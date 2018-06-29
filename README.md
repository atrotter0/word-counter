# Word Counter

#### Epicodus C# independent project, 6.29.18

#### By Abel Trotter

## Description

A class that counts how many times a specific word appears in a string of words. 

## Specs

| Behavior | Input | Output | Reason |
|----------|-------|--------|--------|
| Program checks for null input from user. | null | true | Test to see if input is null from user, if it is, return true. I don't want other methods breaking if input is null. |
| Program downcases user input. | "  Dog  " | dog | Included an uppercase letter in the word and spaces to make sure that the input is downcased and spaces are trimmed. |
| Program checks for a valid word (only accepts letters in words). | %$DHOG&* | false | Included special characters in the word so that the method would return false, marking the word as invalid. |
| Program downcases words in the phrase to find exact word matches. | This is the end, the END my friend. | This is the end, the end my friend. | In order to find an exact word match, I need to downcase all words to match user input. |
| Program strips punctuation from each word in the phrase. | this is the end, the end my friend. | this is the end the end my friend | In order to find an exact word match, I need to remove punctuation from the phrase because 'end,' has a different value than 'end'. |
| Program counts how many times the specified word is found within the inputted phrase. | [Word: Goblins]  [Phrase: the goblins are everywhere dont let the goblins surround us] | 2 | Included two cases of the inputted word in the phrase to check that the program correctly detects duplicate words. |

## Setup on OSX

* Download and install .Net Core 1.1.4
* Download and install Mono
* Clone the repo
* Run `dotnet restore` from within the project directory

## Contribution Requirements

1. Clone the repo
1. Make a new branch
1. Commit and push your changes
1. Create a PR

## Technologies Used

* .Net Core 1.1.4

## Links

* [Github Repo] (https://github.com/atrotter0/word-counter)

## License

This software is licensed under the MIT license.

Copyright (c) 2018 **Abel Trotter**
