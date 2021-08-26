# RepositoryPattren
What is a Repository?
Martin Fowler defines a repository here as below:
A Repository mediates between the domain and data mapping layers, acting like an in-memory domain object collection.
Client objects construct query specifications declaratively and submit them to Repository for satisfaction.
Objects can be added to and removed from the Repository, as they can from a simple collection of objects,
and the mapping code encapsulated by the Repository will carry out the appropriate operations behind the scenes. 
Conceptually, a Repository encapsulates the set of objects persisted in a data store and the operations performed over them,
providing a more object-oriented view of the persistence layer.
Repository also supports the objective of achieving a clean separation and one-way dependency between the domain and data mapping layers.
enjoy
Produced by #Hamed Ebrahimi
