# Word Counter

#### Epicodus C# independent project, 6.29.18

#### By Abel Trotter

## Description

A class that counts how many times a specific word appears in a string of words. 

## Specs

| Behavior | Input | Output |
|----------|-------|--------|
| Program prompts user for a word. | Dog | Counting how many times 'dog' appears in a phrase. |
| Program downcases user input. | Dog | dog |
| Program only allows letters in words. | Dog@#$ | Please enter a valid word. Only letters are allowed. |
| Program prompts user for a phrase. | That was a giant dog we saw the other day! | Your phrase: That was a giant dog we saw the other day! |
| Program downcases words in the phrase to find exact word matches. | This is going to get CRAZY! | this is going to get crazy! |
| Program strips punctuation from each word in the phrase. | this is going to get crazy!!! | this is going to get crazy |
| Program counts how many times the specified word is found within the inputted phrase. | That was a giant dog we saw the other day! | Word: dog, Found: 1 |

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
