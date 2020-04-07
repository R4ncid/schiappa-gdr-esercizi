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

#### Esercizio 6
- risolvere errori nel codice
- il comando fine non termina la partita 
- se non scrivo niente e premo invio il programma si rompe
- gestire i comandi con nome vuoto stampando a schermo "Inserire comando"

#### Esercizio 7
- Definire un interfaccia IAzione in una cartella Azioni
- definire i metodi void SetPartita(Partita partita), void SetParametro(string parametro) ed string Esegui() nell'interfaccia

#### Esercizio 8
- Riscrivere Aiuto Vai e Fine come classi che implementano l'intrefaccia IAzione

#### Esercizio 9
- Aggiungere l'azione Prendi che risponde al comando "prendi nomeAttrezzo" 
- Nel metodo **Esegui** implementare la seguente logica:
- Se l'attrezzo con nome nomeAttrezzo non è presente stampare il messaggio "non trovo " + nomeAttrezzo
- Se l'attrezzo è presente rimuoverlo dalla stanza e aggiungerlo nella borsa del giocatore (usa i metodi **HasAttrezzo** e **GetAttrezzo** e **RemoveAttrezzo** di **Stanza** e **AddAttrezzo** di **Borsa**)


#### Esercizio 10
- Usando la stessa logica implementa l'azione **Posa** ( esempio di comando "posa nomeAttrezzo")
- Controlla se l'attrezzo è nella borsa
- Se c'è rimuovilo dalla borsa e aggiungilo alla stanza

#### Esercizio 11
- Creare una class AzioneSconosciuta che implementa l'interfaccia **IAzione**
- Il metodo Esegui di AzioneSconosciuta restituisce la stringa "Comando sconosciuto"

#### Esercizio 12
- Creare un'interfaccia **IAzioneFactory** con un metodo IAzione Crea(Comando comando)
- Creare una class AzioneFactorySemplice che implementa l'interfaccia **IAzioneFactory**
- Nel metoto Crea copiare il codice che c'è nel processatore istruzioni ma invece di richiamare i vari metodi restituire un'istanza della classe Azione
- es. se comando.GetNome() = "aiuto" il metodo Crea restituisce new Aiuto()
- Se non trova una classe azione ritorna AzioneSconosciuta

