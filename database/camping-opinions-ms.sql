CREATE TABLE mnenja (
  mnenje_id SERIAL PRIMARY KEY NOT NULL,
  mnenje VARCHAR(1000),
  ocena INT,
  uporabnik INT NOT NULL,
  avtokamp INT NOT NULL
);
