# README: How to Add Languages for IHF Rules and Questions

## Overview

This project manages the IHF rules and questions in multiple languages. I updated the structure to make it easier for everyone who wants to contribute. To add a new language or complete missing translations, follow the instructions below.

## File Structure

The rules are defined in a RuleDto object that contains a list of QuestionDto objects, which in turn hold AnswerDto objects. There will be a separate folder for each language.

Translations for the UI are stored in JSON files (`en.json`, `nl.json` `srb.json`, etc.).


## Versions

It can be that the languages are not updated at the same time for all languages. Ex. English can already contain the latest version, but Dutch is not updated yet.

Therefore there is also a version.json file for each language.

Here an overview of all versions:

| Language    | Version |
| -------- | ------- |
| English  | 1 Juli 2024    |
| Dutch | 1 juli 2024     |
| Serbian    | 1. Јула 2024    |


## Adding a New Language

### Copy the _Template folder:

To support a new language, such as Spanish, first copy the "_Template" folder and paste it with the name of the language code, in this example "es".

Populate the new Language in the Rule(number).json files:
For example:

```json
{
  "RuleNumber": "1",
  "Name": "El campo de juego",
  "Questions": [
    {
      "QuestionNumber": "1.1",
      "Phrase": "¿Cuáles son las medidas del campo de juego según las reglas?",
      "Answers": [
        {
          "AnswerNumber": "a",
          "Phrase": "20x40",
          "Correct": true
        }
      ]
    },
  ]
}
```

## JSON Translation Files for the UI (website)

The JSON files (en.json, nl.json, srb.json, etc.) contain translations for various parts of the UI. Each file includes a structure for different sections like "home", "navigation", "questions", etc.

### Adding a New Language in JSON Files

#### Duplicate the _template JSON File:

If you are adding a new language, start by copying the _template.json file.

#### Translate Each Key:

Translate each value in the JSON file to the new language. For example, if creating a Spanish (es.json) file:

```json
"home": {
    "alert": "Por ahora, solo están disponibles las versiones en inglés y holandés. Tan pronto como estén disponibles las versiones en otros idiomas (francés, alemán, esloveno,...), se publicarán.",
    "all_questions_card": {
        "button": "Responder todas las preguntas",
        "content": "Ve a la lista de todas las preguntas.",
        "title": "Todas las preguntas"
    }
}
```

#### Add the New Language to the Language Switcher:

Update the languages section in each JSON file to include the new language.

## Creating a Pull Request

Once you've made your changes to the code, you can submit them for review by creating a pull request (PR). Follow these steps:

### Fork the Repository:

If you haven't already, fork the repository to your own GitHub account.

### Clone Your Fork:

Clone your fork to your local machine using the following command:

```bash
git clone https://github.com/KristofGilis/ihf_rules_questions.git
```

Replace your-username with your GitHub username and repository-name with the repository's name.

### Create a New Branch:

Create a new branch for your changes. It's good practice to name your branch based on the feature or fix you're implementing:

```bash
git checkout -b add-spanish-translations
```

### Make Your Changes:

Edit the files to add the new language or fill in missing translations.

### Commit Your Changes:

Once you're happy with your changes, commit them with a meaningful message:

```bash
git add .
git commit -m "Added Spanish translations"
```

### Push Your Changes:

Push your changes to your fork on GitHub:

```bash
git push origin add-spanish-translations
```

### Create a Pull Request:

Go to your fork on GitHub, and you should see an option to create a pull request. Click on it and provide a clear description of the changes you made.

### Wait for Review:

Once submitted, your pull request will be reviewed by the project maintainers. They may ask for changes or approve your pull request directly.

#### Note

If you encounter any issues with creating a pull request, or if you prefer, you can also email your changes directly to kristof.gilis@outlook.be for review and inclusion.

## Conclusion

By following these instructions, you can easily add new languages, fill in missing translations, and submit your changes for review via a pull request. Alternatively, you can email your changes directly for review. Ensure all changes are consistent across the project to maintain the integrity of the multilingual support.

## Special thanks to our contributors

<table>
  <tbody>
    <tr>
    <td align="center" valign="top" width="14.28%"><a href="https://github.com/KristofGilis"><img src="https://avatars.githubusercontent.com/u/2454275?v=4?s=100" width="100px;" alt="Kristof Gilis"/><br /><sub><b>Kristof Gilis</b></sub></a><br /><a href="https://github.com/KristofGilis/ihf_rules_questions/commits?author=KristofGilis" title="Code"> En / Nl</a></td>
      <td align="center" valign="top" width="14.28%"><a href="https://github.com/branislavrt4316"><img src="https://avatars.githubusercontent.com/u/55112798?v=4?s=100" width="100px;" alt="Branislav Vujanovic"/><br /><sub><b>Branislav Vujanovic</b></sub></a><br /><a href="https://github.com/KristofGilis/ihf_rules_questions/commits?author=branislavrt4316" title="Code">Srb</a></td>
    </tr>
  </tbody>
</table>
