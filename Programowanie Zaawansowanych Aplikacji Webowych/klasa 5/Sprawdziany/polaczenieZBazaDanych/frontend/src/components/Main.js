import { useEffect, useState } from 'react';

const API_URL = process.env.REACT_APP_API_URL || 'http://localhost:5000';

async function request(path, options) {
  const response = await fetch(`${API_URL}${path}`, options);
  const data = await response.json();

  if (!response.ok) {
    throw new Error(data.error || 'Nie udało się wykonać zapytania.');
  }

  return data;
}

function BookList({ books }) {
  return (
    <ol>
      {books.map((book) => (
        <li key={book.id}>
          {book.title} — {book.author}
          <img
            src={`${API_URL}${book.cover}`}
            alt={`Okładka książki „${book.title}”`}
          />
        </li>
      ))}
    </ol>
  );
}

function Main() {
  const [books, setBooks] = useState([]);
  const [authors, setAuthors] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState('');
  const [title, setTitle] = useState('');
  const [author, setAuthor] = useState('');
  const [newAuthor, setNewAuthor] = useState('');
  const [titleResults, setTitleResults] = useState(null);
  const [authorResults, setAuthorResults] = useState(null);
  const [message, setMessage] = useState('');

  useEffect(() => {
    async function loadData() {
      try {
        const bookData = await request('/api/books');
        setBooks(bookData);

        const authorData = await request('/api/authors');
        setAuthors(authorData);
      } catch (loadError) {
        setError(`Nie udało się pobrać danych z bazy księgarnia: ${loadError.message}`);
      } finally {
        setLoading(false);
      }
    }

    loadData();
  }, []);

  function searchTitle(event) {
    event.preventDefault();
    const query = title.trim().toLocaleLowerCase('pl-PL');
    setTitleResults(books.filter(
      (book) => book.title.toLocaleLowerCase('pl-PL') === query,
    ));
  }

  function searchAuthor(event) {
    event.preventDefault();
    const query = author.trim().toLocaleLowerCase('pl-PL');
    setAuthorResults(books.filter(
      (book) => book.author.toLocaleLowerCase('pl-PL') === query,
    ));
  }

  function addAuthor(event) {
    event.preventDefault();
    setMessage('');

    const name = newAuthor.trim();
    setAuthors((currentAuthors) => [
      ...currentAuthors,
      { id: `local-${Date.now()}`, name },
    ]);
    setNewAuthor('');
    setMessage(`Dodano autora: ${name}.`);
  }

  return (
    <main>
      {error && <p role="alert">{error}</p>}
      {loading ? <p>Wczytywanie danych...</p> : (
        <>
          <section>
            <h2>Oferta księgarni</h2>
            <BookList books={books} />
          </section>

          <section>
            <h2>Sprawdź tytuł książki</h2>
            <form onSubmit={searchTitle}>
              <label htmlFor="title">Tytuł książki:</label>
              <input id="title" value={title} onChange={(event) => setTitle(event.target.value)} required />
              <button type="submit">Sprawdź</button>
            </form>
            {titleResults && (
              titleResults.length
                ? <BookList books={titleResults} />
                : <p>Nie znaleziono takiego tytułu w ofercie.</p>
            )}
          </section>

          <section>
            <h2>Sprawdź książki autora</h2>
            <form onSubmit={searchAuthor}>
              <label htmlFor="author">Imię i nazwisko:</label>
              <input id="author" value={author} onChange={(event) => setAuthor(event.target.value)} required />
              <button type="submit">Sprawdź</button>
            </form>
            {authorResults && (
              authorResults.length
                ? <BookList books={authorResults} />
                : <p>Nie znaleziono książek tego autora.</p>
            )}
          </section>

          <section>
            <h2>Autorzy</h2>
            <form onSubmit={addAuthor}>
              <label htmlFor="new-author">Dodaj autora:</label>
              <input
                id="new-author"
                value={newAuthor}
                onChange={(event) => setNewAuthor(event.target.value)}
                required
              />
              <button type="submit">Dodaj</button>
            </form>
            {message && <p role="status">{message}</p>}
            <ol>
              {authors.map((item) => <li key={item.id}>{item.name}</li>)}
            </ol>
          </section>
        </>
      )}
    </main>
  );
}

export default Main;
