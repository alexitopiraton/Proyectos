#define __POKEMON.H_
#ifndef __POKEMON.H_

#include <Pokedex.h>


class pokemon {
    public:

    private:
    string nombre;
    int numeroPokedex;
    string tipo;
    bool capturado;
    int altura;
    int peso;
    Pokedex *infoPokemon;
}

#endif