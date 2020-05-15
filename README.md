# Word Counter App

## by Ethan Firpo (2020)

## Description

This program will allow a user to enter a word, then enter a sentence and see how often that word appears in the sentence.

## Setup

Clone this Repository. 
Make Sure You Have .Net Installed on Your Machine. 
Open The Folder in Your Text Editor. 
Build in Console with Dotnet Build. 
Run in Console with Dotnet Run. 

## Technology

#### C#
#### .NET
#### MSTest

## Specs
|Behavior|Input|Output|
|-----|-----|-----|
|Program will accept a word from the user|"chuck"|true|
|Program will accept a sentence from the user|"how much wood would a woodchuck chuck if a woodchuck could chuck wood?"|true|
|Program will check if word contains numbers|"ch4ck"|false|
|Program will check if word contains special characters|"ch*ck"|false|
|Program will count how many times word appears in the sentence|"chuck", "how much wood would a woodchuck chuck if a woodchuck could chuck wood?"|2|


## Legal

#### MIT License

### Copyright (c) 2020 Ethan Alexander Firpo

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
