/*Hechos*/

hombre(hernan_p).
hombre(julio_d_2).
hombre(ludwing_p).
hombre(alex_d).
hombre(harold_d).
hombre(julio_d).
hombre(juan_d).
hombre(jacobo_d).
hombre(santiago_p).

mujer(mercedes_s).
mujer(miriam_g).
mujer(nazly_d).
mujer(liliana_p).
mujer(camila_d).
mujer(sara_d).
mujer(aleja_p).

/*Reglas*/
/*Primera linea*/

abuelo_de(juan_d, hernan_p).
abuelo_de(juan_d, julio_d_2).
abuelo_de(camila_d, hernan_p).
abuelo_de(camila_d, julio_d_2).

abuela_de(juan_d, mercedes_s).
abuela_de(juan_d, miriam_g).
abuela_de(camila_d, mercedes_s).
abuela_de(camila_d, miriam_g).

nieto_de(hernan_p, juan_d).
nieto_de(mercedes_s, juan_d).
nieto_de(julio_d_2, juan_d).
nieto_de(miriam_g, juan_d).

nieta_de(hernan_p, camila_d).
nieta_de(mercedes_s, camila_d).
nieta_de(julio_d_2, camila_d).
nieta_de(miriam_g, camila_d).

papa_de(liliana_p, hernan_p).
papa_de(ludwing_p, hernan_p).
papa_de(julio_d, julio_d_2).
papa_de(alex_d, julio_d_2).
papa_de(harold_d, julio_d_2).
papa_de(nazly_d, julio_d_2).
papa_de(jacobo_d, harold_d).
papa_de(sara_d, harold_d).
papa_de(santiago_p, ludwing_p).
papa_de(aleja_p, ludwing_p).
papa_de(juan_d, julio_d).
papa_de(camila_d, julio_d).

mama_de(julio_d, miriam_g).
mama_de(alex_d, miriam_g).
mama_de(harold_d, miriam_g).
mama_de(nazly_d, miriam_g).
mama_de(liliana_p, mercedes_s).
mama_de(ludwing_p, mercedes_s).
mama_de(juan_d, liliana_p).
mama_de(camila_d, liliana_p).

hijo_de(hernan_p, ludwing_p).
hijo_de(mercedes_s, ludwing_p).
hijo_de(julio_d_2, harold_d).
hijo_de(julio_d_2, alex_d).
hijo_de(julio_d_2, julio_d).
hijo_de(miriam_g, harold_d).
hijo_de(miriam_g, alex_d).
hijo_de(miriam_g, julio_d).
hijo_de(julio_d, juan_d).
hijo_de(liliana_p, juan_d).

hija_de(julio_d_2, nazly_d).
hija_de(miriam_g, nazly_d).
hija_de(hernan_p, liliana_p).
hija_de(mercedes_s, liliana_p).
hija_de(julio_d, camila_d).
hija_de(liliana_p, camila_d).

hermano_de(nazly_d, harold_d).
hermano_de(nazly_d, alex_d).
hermano_de(nazly_d, julio_d).
hermano_de(harold_d, alex_d).
hermano_de(harold_d, julio_d).
hermano_de(alex_d, harold_d).
hermano_de(alex_d, julio_d).
hermano_de(julio_d, harold_d).
hermano_de(julio_d, alex_d).
hermano_de(liliana_p, ludwing_p).
hermano_de(sara_d, jacobo_d).
hermano_de(aleja_p, santiago_p).
hermano_de(camila_d, juan_d).

hermana_de(harold_d, nazly_d).
hermana_de(alex_d, nazly_d).
hermana_de(julio_d, nazly_d).
hermana_de(ludwing_p, liliana_p).
hermana_de(jacobo_d, sara_d).
hermana_de(santiago_p, aleja_p).
hermana_de(juan_d, camila_d).

/*Segunda linea*/

tio_de(juan_d, harold_d).
tio_de(juan_d, alex_d).
tio_de(juan_d, ludwing_p).
tio_de(camila_d, harold_d).
tio_de(camila_d, alex_d).
tio_de(camila_d, ludwing_p).

tia_de(juan_d, nazly_d).
tia_de(camila_d, nazly_d).

sobrino_de(harold_d, juan_d).
sobrino_de(alex_d, juan_d).
sobrino_de(nazly_d, juan_d).
sobrino_de(ludwing_p, juan_d).
sobrino_de(julio_d, jacobo_d).
sobrino_de(julio_d, santiago_p).
sobrino_de(liliana_p, jacobo_d).
sobrino_de(liliana_p, santiago_p).

sobrina_de(harold_d, camila_d).
sobrina_de(alex_d, camila_d).
sobrina_de(nazly_d, camila_d).
sobrina_de(ludwing_p, camila_d).
sobrina_de(julio_d, sara_d).
sobrina_de(julio_d, aleja_p).
sobrina_de(liliana_p, sara_d).
sobrina_de(liliana_p, aleja_p).

primo_de(jacobo_d, juan_d).
primo_de(sara_d, juan_d).
primo_de(santiago_p, juan_d).
primo_de(aleja_p, juan_d).
primo_de(juan_d, jacobo_d).
primo_de(juan_d, santiago_p).
primo_de(camila_d, jacobo_d).
primo_de(camila_d, santiago_p).

prima_de(jacobo_d, camila_d).
prima_de(santiago_p, camila_d).
prima_de(sara_d, camila_d).
prima_de(aleja_p, camila_d).
prima_de(camila_d, sara_d).
prima_de(camila_d, aleja_p).

/*Relaciones extra*/

esposa_de(julio_d_2, miriam_g).
esposo_de(liliana_p, julio_d).

esposa_de(julio_d_2, miriam_g).
esposa_de(julio_d, liliana_p).

suegro_de(julio_d, hernan_p).
suegro_de(liliana_p, julio_d_2).

suegra_de(julio_d, mercedes_s).
suegra_de(liliana_p, miriam_g).


