# ScottPlot Website

This repository tracks source code for content displayed on http://swharden.com/scottplot

## Develop in Docker

The website in repository is ready to run in Docker!

Run `docker-compose up -d` then visit http://localhost:8083

## Deploy with GitHub Actions

* Clone this repo in a folder outside the web root
* Symbolically link `src` to a web-accessible path
* Create a secret `API_KEY` in the GitHub project
* Store the key in `api.key` in the root folder (chmod `400`)
* Configure GitHub Actions to HTTP request `/deploy` when new commits are pushed, using the `API_KEY` as a bearer token (see [main.yml](.github/workflows/main.yml))