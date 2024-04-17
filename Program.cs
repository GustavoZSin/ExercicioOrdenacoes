using TesteOrdenacao;

//Geração de listas
Gerador gerador = new();
ListaDuplamenteEncadeada listaOrdenada = gerador.GerarListaOrdenada();
ListaDuplamenteEncadeada listaDesordenada = gerador.GerarListaDesordenada();
ListaDuplamenteEncadeada listaInversamenteOrdenada = gerador.GerarListaInversamenteOrdenada();
int insercoes = 0, comparacoes = 0;

#region Bubble Sort
Console.WriteLine($"Bubble Sort");
ListaDuplamenteEncadeada lBubbleSortOrdenada1 = Ordenador.BubbleSort(listaOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"Lista Ordenada:");
lBubbleSortOrdenada1.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lBubbleSortOrdenada2 = Ordenador.BubbleSort(listaDesordenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Desordenada:");
lBubbleSortOrdenada2.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lBubbleSortOrdenada3 = Ordenador.BubbleSort(listaInversamenteOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Inversamente Ordenada:");
lBubbleSortOrdenada3.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");
#endregion

#region Selection Sort
Console.WriteLine($"\n\nSelection Sort");
ListaDuplamenteEncadeada lSelectionSortOrdenada1 = Ordenador.SelectionSort(listaOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"Lista Ordenada:");
lSelectionSortOrdenada1.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lSelectionSortOrdenada2 = Ordenador.SelectionSort(listaDesordenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Desordenada:"); 
lSelectionSortOrdenada2.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lSelectionSortOrdenada3 = Ordenador.SelectionSort(listaInversamenteOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Inversamente Ordenada:"); 
lSelectionSortOrdenada3.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");
#endregion

#region Insertion Sort
Console.WriteLine($"\n\nInsertion Sort");
ListaDuplamenteEncadeada lInsertionSortOrdenada1 = Ordenador.InsertionSort(listaOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"Lista Ordenada:");
lInsertionSortOrdenada1.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lInsertionSortOrdenada2 = Ordenador.InsertionSort(listaDesordenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Desordenada:"); 
lInsertionSortOrdenada2.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lInsertionSortOrdenada3 = Ordenador.InsertionSort(listaInversamenteOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Inversamente Ordenada:"); 
lInsertionSortOrdenada3.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");
#endregion

#region Merge Sort
Console.WriteLine($"\n\nMerge Sort");
ListaDuplamenteEncadeada lMergeSortOrdenada1 = Ordenador.MergeSort(listaOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"Lista Ordenada:");
lMergeSortOrdenada1.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lMergeSortOrdenada2 = Ordenador.MergeSort(listaDesordenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Desordenada:"); 
lMergeSortOrdenada2.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lMergeSortOrdenada3 = Ordenador.MergeSort(listaInversamenteOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Inversamente Ordenada:"); 
lMergeSortOrdenada3.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");
#endregion

#region Quick Sort
Console.WriteLine($"\n\nQuick Sort"); 
ListaDuplamenteEncadeada lQuickSortOrdenada1 = Ordenador.QuickSort(listaOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"Lista Ordenada:"); 
lQuickSortOrdenada1.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lQuickSortOrdenada2 = Ordenador.QuickSort(listaDesordenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Desordenada:"); 
lQuickSortOrdenada2.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lQuickSortOrdenada3 = Ordenador.QuickSort(listaInversamenteOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Inversamente Ordenada:"); 
lQuickSortOrdenada3.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");
#endregion

#region Tree Sort
Console.WriteLine($"\n\nTree Sort");
ListaDuplamenteEncadeada lTreeSortOrdenada1 = Ordenador.TreeSort(listaOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"Lista Ordenada:");
lTreeSortOrdenada1.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lTreeSortOrdenada2 = Ordenador.TreeSort(listaDesordenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Desordenada:"); 
lTreeSortOrdenada2.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");

ListaDuplamenteEncadeada lTreeSortOrdenada3 = Ordenador.TreeSort(listaInversamenteOrdenada, out insercoes, out comparacoes);
Console.WriteLine($"\nLista Inversamente Ordenada:"); 
lTreeSortOrdenada3.Exibir();
Console.WriteLine($"Inserções/Trocas: {insercoes}");
Console.WriteLine($"Comparações: {comparacoes}");
#endregion