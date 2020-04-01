# schiappa-gdr-esercizi
###Piccolo progetto di un gdr testuale per imparare OOP 

#### Esercizio 1
 - Definire una classe **Labirinto** che si occupa di gestire il labirinto e spostare tutta la logica di creazione del labirinto all'interno di essa
 - Aggiungere all'interno della classe partita un metodo GetLabirinto che restituisce il labirinto
 
#### Esercizio 2
 - Definire una classe **Giocatore** per gestire l'energia del giocatore e definire un metodo IsVivo che restituisce true se l'energia è maggiore di zero e false altrimenti
 
#### Esercizio 3 
 - Definire una classe **Borsa** e assegnarla al personaggio
 - La classe Borsa ha al sua interno un array di attrezzi inizialmente vuoto
 - Aggiungere i metodi **AddAttrezzo(Attrezzo attrezzo)**, **HasAttrezzo(string nomeAttrezzo)**, **GetAttrezzo(string nomeAttrezzo)** e **RemoveAttrezzo(string nomeAttrezzo)** alla classe **Borsa** 
 
#### Esercizio 4
 - Rifattorizzare la classe **Schiappa**
 - Creare una classe **ProcessatoreIstruzioni** che si occupa di processare le istruzioni
 - Aggiungere un construttore ProcessatoreIstruzioni(Partita partita) a cui viene passata la partita
 - Spostare tutti i metodi legati alle azioni (Vai, Aiuto e Fine) all'interno della nuova classe
 - Aggiungere un metodo bool Processa(string istruzione) all'interno della classe ProcessatoreIstruzioni e copiare il contenuto di ProcessaIstruzione dentro di essa
 
#### Esercizio 5
- aggiungere comando guarda
- aggiungere all'array dei comandi 'guarda'
- creare un metodo privato Guarda alla classe **ProcessatoreIstruzioni** che stampa la descrizione della stanza corrente
- aggiungere una condizione nel metodo processa che chiama il metodo Guarda