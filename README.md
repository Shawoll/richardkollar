# richardkollar.sk

Personal home page (`index.html`) plus a few standalone mini apps. Static files, no build step.

## Mini apps

One HTML file each, in `apps/`:

- [Silly Shirt Studio](https://richardkollar.sk/apps/sss.html) – `apps/sss.html`
- [NOMAD – Urban Barefoot Sneaker Concept](https://richardkollar.sk/apps/nomad.html) – `apps/nomad.html`
- [Shoe Pairing – Welcome to the Family](https://richardkollar.sk/apps/fam.html) – `apps/fam.html`
- [Bare Family – Pair your shoes](https://richardkollar.sk/apps/fam2.html) – `apps/fam2.html`
- [Developer Star Evaluation](https://richardkollar.sk/apps/chart.html) – `apps/chart.html`

## Folders

- `apps/` – mini apps
- `assets/` – fonts (used by the home page) and icons
- `api/` – static mock API pages
- `blog/` – redirect to the blog

## Run locally

```
python3 -m http.server 8123
```

Then open http://127.0.0.1:8123/ for the home page, or http://127.0.0.1:8123/apps/sss.html for an app.
