* Removed requirement to use Enumerable of root element names from the IndexedXmlFileReader.  Reader now reads and caches all top level elements found in the file.  This fixes bug #77261338 - StudentEnrollment not accepting SectionReference.