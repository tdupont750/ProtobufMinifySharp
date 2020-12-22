// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AddressBook.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from AddressBook.proto</summary>
public static partial class AddressBookReflection {

  #region Descriptor
  /// <summary>File descriptor for AddressBook.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static AddressBookReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChFBZGRyZXNzQm9vay5wcm90byLVAQoGUGVyc29uEgwKBG5hbWUYASABKAkS",
          "CgoCaWQYAiABKAUSDQoFZW1haWwYAyABKAkSIwoGcGhvbmVzGAQgAygLMhMu",
          "UGVyc29uLlBob25lTnVtYmVyEhAKCGhhc1RoaW5nGAUgASgIGj4KC1Bob25l",
          "TnVtYmVyEg4KBm51bWJlchgBIAEoCRIfCgR0eXBlGAIgASgOMhEuUGVyc29u",
          "LlBob25lVHlwZSIrCglQaG9uZVR5cGUSCgoGTU9CSUxFEAASCAoESE9NRRAB",
          "EggKBFdPUksQAiImCgtBZGRyZXNzQm9vaxIXCgZwZW9wbGUYASADKAsyBy5Q",
          "ZXJzb24iKAoMQW5vdGhlclRoaW5nEgwKBG5hbWUYASABKAkSCgoCaWQYAiAB",
          "KAU="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Person), global::Person.Parser, new[]{ "Name", "Id", "Email", "Phones", "HasThing" }, null, new[]{ typeof(global::Person.Types.PhoneType) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Person.Types.PhoneNumber), global::Person.Types.PhoneNumber.Parser, new[]{ "Number", "Type" }, null, null, null, null)}),
          new pbr::GeneratedClrTypeInfo(typeof(global::AddressBook), global::AddressBook.Parser, new[]{ "People" }, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::AnotherThing), global::AnotherThing.Parser, new[]{ "Name", "Id" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Person : pb::IMessage<Person>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
  private pb::UnknownFieldSet _unknownFields;
  private int _hasBits0;
  public static pb::MessageParser<Person> Parser { get { return _parser; } }
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AddressBookReflection.Descriptor.MessageTypes[0]; }
  }
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }
  public Person() {
    OnConstruction();
  }

  partial void OnConstruction();
  public Person(Person other) : this() {
    _hasBits0 = other._hasBits0;
    name_ = other.name_;
    id_ = other.id_;
    email_ = other.email_;
    phones_ = other.phones_.Clone();
    hasThing_ = other.hasThing_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }
  public Person Clone() {
    return new Person(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private readonly static string NameDefaultValue = "";

  private string name_;
  public string Name {
    get { return name_ ?? NameDefaultValue; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }
  public bool HasName {
    get { return name_ != null; }
  }
  public void ClearName() {
    name_ = null;
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 2;
  private readonly static int IdDefaultValue = 0;

  private int id_;
  public int Id {
    get { if ((_hasBits0 & 1) != 0) { return id_; } else { return IdDefaultValue; } }
    set {
      _hasBits0 |= 1;
      id_ = value;
    }
  }
  public bool HasId {
    get { return (_hasBits0 & 1) != 0; }
  }
  public void ClearId() {
    _hasBits0 &= ~1;
  }

  /// <summary>Field number for the "email" field.</summary>
  public const int EmailFieldNumber = 3;
  private readonly static string EmailDefaultValue = "";

  private string email_;
  public string Email {
    get { return email_ ?? EmailDefaultValue; }
    set {
      email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }
  public bool HasEmail {
    get { return email_ != null; }
  }
  public void ClearEmail() {
    email_ = null;
  }

  /// <summary>Field number for the "phones" field.</summary>
  public const int PhonesFieldNumber = 4;
  private static readonly pb::FieldCodec<global::Person.Types.PhoneNumber> _repeated_phones_codec
      = pb::FieldCodec.ForMessage(34, global::Person.Types.PhoneNumber.Parser);
  private readonly pbc::RepeatedField<global::Person.Types.PhoneNumber> phones_ = new pbc::RepeatedField<global::Person.Types.PhoneNumber>();
  public pbc::RepeatedField<global::Person.Types.PhoneNumber> Phones {
    get { return phones_; }
  }

  /// <summary>Field number for the "hasThing" field.</summary>
  public const int HasThingFieldNumber = 5;
  private readonly static bool HasThingDefaultValue = false;

  private bool hasThing_;
  public bool HasThing {
    get { if ((_hasBits0 & 2) != 0) { return hasThing_; } else { return HasThingDefaultValue; } }
    set {
      _hasBits0 |= 2;
      hasThing_ = value;
    }
  }
  public bool HasHasThing {
    get { return (_hasBits0 & 2) != 0; }
  }
  public void ClearHasThing() {
    _hasBits0 &= ~2;
  }
  public override bool Equals(object other) {
    return Equals(other as Person);
  }
  public bool Equals(Person other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (Id != other.Id) return false;
    if (Email != other.Email) return false;
    if(!phones_.Equals(other.phones_)) return false;
    if (HasThing != other.HasThing) return false;
    return Equals(_unknownFields, other._unknownFields);
  }
  public override int GetHashCode() {
    int hash = 1;
    if (HasName) hash ^= Name.GetHashCode();
    if (HasId) hash ^= Id.GetHashCode();
    if (HasEmail) hash ^= Email.GetHashCode();
    hash ^= phones_.GetHashCode();
    if (HasHasThing) hash ^= HasThing.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (HasName) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    if (HasId) {
      output.WriteRawTag(16);
      output.WriteInt32(Id);
    }
    if (HasEmail) {
      output.WriteRawTag(26);
      output.WriteString(Email);
    }
    phones_.WriteTo(output, _repeated_phones_codec);
    if (HasHasThing) {
      output.WriteRawTag(40);
      output.WriteBool(HasThing);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (HasName) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    if (HasId) {
      output.WriteRawTag(16);
      output.WriteInt32(Id);
    }
    if (HasEmail) {
      output.WriteRawTag(26);
      output.WriteString(Email);
    }
    phones_.WriteTo(ref output, _repeated_phones_codec);
    if (HasHasThing) {
      output.WriteRawTag(40);
      output.WriteBool(HasThing);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }

#endif
  public int CalculateSize() {
    int size = 0;
    if (HasName) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (HasId) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    if (HasEmail) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
    }
    size += phones_.CalculateSize(_repeated_phones_codec);
    if (HasHasThing) {
      size += 1 + 1;
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }
  public void MergeFrom(Person other) {
    if (other == null) {
      return;
    }
    if (other.HasName) {
      Name = other.Name;
    }
    if (other.HasId) {
      Id = other.Id;
    }
    if (other.HasEmail) {
      Email = other.Email;
    }
    phones_.Add(other.phones_);
    if (other.HasHasThing) {
      HasThing = other.HasThing;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Id = input.ReadInt32();
          break;
        }
        case 26: {
          Email = input.ReadString();
          break;
        }
        case 34: {
          phones_.AddEntriesFrom(input, _repeated_phones_codec);
          break;
        }
        case 40: {
          HasThing = input.ReadBool();
          break;
        }
      }
    }
  #endif
  }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Id = input.ReadInt32();
          break;
        }
        case 26: {
          Email = input.ReadString();
          break;
        }
        case 34: {
          phones_.AddEntriesFrom(ref input, _repeated_phones_codec);
          break;
        }
        case 40: {
          HasThing = input.ReadBool();
          break;
        }
      }
    }
  }

#endif
#region Nested types
  public static partial class Types {
    public enum PhoneType {
      [pbr::OriginalName("MOBILE")] Mobile = 0,
      [pbr::OriginalName("HOME")] Home = 1,
      [pbr::OriginalName("WORK")] Work = 2,
    }

    public sealed partial class PhoneNumber : pb::IMessage<PhoneNumber>
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        , pb::IBufferMessage
    #endif
    {
      private static readonly pb::MessageParser<PhoneNumber> _parser = new pb::MessageParser<PhoneNumber>(() => new PhoneNumber());
      private pb::UnknownFieldSet _unknownFields;
      private int _hasBits0;
      public static pb::MessageParser<PhoneNumber> Parser { get { return _parser; } }
      public static pbr::MessageDescriptor Descriptor {
        get { return global::Person.Descriptor.NestedTypes[0]; }
      }
      pbr::MessageDescriptor pb::IMessage.Descriptor {
        get { return Descriptor; }
      }
      public PhoneNumber() {
        OnConstruction();
      }

      partial void OnConstruction();
      public PhoneNumber(PhoneNumber other) : this() {
        _hasBits0 = other._hasBits0;
        number_ = other.number_;
        type_ = other.type_;
        _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
      }
      public PhoneNumber Clone() {
        return new PhoneNumber(this);
      }

      /// <summary>Field number for the "number" field.</summary>
      public const int NumberFieldNumber = 1;
      private readonly static string NumberDefaultValue = "";

      private string number_;
      public string Number {
        get { return number_ ?? NumberDefaultValue; }
        set {
          number_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        }
      }
      public bool HasNumber {
        get { return number_ != null; }
      }
      public void ClearNumber() {
        number_ = null;
      }

      /// <summary>Field number for the "type" field.</summary>
      public const int TypeFieldNumber = 2;
      private readonly static global::Person.Types.PhoneType TypeDefaultValue = global::Person.Types.PhoneType.Mobile;

      private global::Person.Types.PhoneType type_;
      public global::Person.Types.PhoneType Type {
        get { if ((_hasBits0 & 1) != 0) { return type_; } else { return TypeDefaultValue; } }
        set {
          _hasBits0 |= 1;
          type_ = value;
        }
      }
      public bool HasType {
        get { return (_hasBits0 & 1) != 0; }
      }
      public void ClearType() {
        _hasBits0 &= ~1;
      }
      public override bool Equals(object other) {
        return Equals(other as PhoneNumber);
      }
      public bool Equals(PhoneNumber other) {
        if (ReferenceEquals(other, null)) {
          return false;
        }
        if (ReferenceEquals(other, this)) {
          return true;
        }
        if (Number != other.Number) return false;
        if (Type != other.Type) return false;
        return Equals(_unknownFields, other._unknownFields);
      }
      public override int GetHashCode() {
        int hash = 1;
        if (HasNumber) hash ^= Number.GetHashCode();
        if (HasType) hash ^= Type.GetHashCode();
        if (_unknownFields != null) {
          hash ^= _unknownFields.GetHashCode();
        }
        return hash;
      }
      public override string ToString() {
        return pb::JsonFormatter.ToDiagnosticString(this);
      }
      public void WriteTo(pb::CodedOutputStream output) {
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        output.WriteRawMessage(this);
      #else
        if (HasNumber) {
          output.WriteRawTag(10);
          output.WriteString(Number);
        }
        if (HasType) {
          output.WriteRawTag(16);
          output.WriteEnum((int) Type);
        }
        if (_unknownFields != null) {
          _unknownFields.WriteTo(output);
        }
      #endif
      }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
        if (HasNumber) {
          output.WriteRawTag(10);
          output.WriteString(Number);
        }
        if (HasType) {
          output.WriteRawTag(16);
          output.WriteEnum((int) Type);
        }
        if (_unknownFields != null) {
          _unknownFields.WriteTo(ref output);
        }
      }

#endif
      public int CalculateSize() {
        int size = 0;
        if (HasNumber) {
          size += 1 + pb::CodedOutputStream.ComputeStringSize(Number);
        }
        if (HasType) {
          size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
        }
        if (_unknownFields != null) {
          size += _unknownFields.CalculateSize();
        }
        return size;
      }
      public void MergeFrom(PhoneNumber other) {
        if (other == null) {
          return;
        }
        if (other.HasNumber) {
          Number = other.Number;
        }
        if (other.HasType) {
          Type = other.Type;
        }
        _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
      }
      public void MergeFrom(pb::CodedInputStream input) {
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        input.ReadRawMessage(this);
      #else
        uint tag;
        while ((tag = input.ReadTag()) != 0) {
          switch(tag) {
            default:
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
              break;
            case 10: {
              Number = input.ReadString();
              break;
            }
            case 16: {
              Type = (global::Person.Types.PhoneType) input.ReadEnum();
              break;
            }
          }
        }
      #endif
      }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
        uint tag;
        while ((tag = input.ReadTag()) != 0) {
          switch(tag) {
            default:
              _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
              break;
            case 10: {
              Number = input.ReadString();
              break;
            }
            case 16: {
              Type = (global::Person.Types.PhoneType) input.ReadEnum();
              break;
            }
          }
        }
      }
      #endif

    }

  }
  #endregion

}

public sealed partial class AddressBook : pb::IMessage<AddressBook>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AddressBook> _parser = new pb::MessageParser<AddressBook>(() => new AddressBook());
  private pb::UnknownFieldSet _unknownFields;
  public static pb::MessageParser<AddressBook> Parser { get { return _parser; } }
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AddressBookReflection.Descriptor.MessageTypes[1]; }
  }
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }
  public AddressBook() {
    OnConstruction();
  }

  partial void OnConstruction();
  public AddressBook(AddressBook other) : this() {
    people_ = other.people_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }
  public AddressBook Clone() {
    return new AddressBook(this);
  }

  /// <summary>Field number for the "people" field.</summary>
  public const int PeopleFieldNumber = 1;
  private static readonly pb::FieldCodec<global::Person> _repeated_people_codec
      = pb::FieldCodec.ForMessage(10, global::Person.Parser);
  private readonly pbc::RepeatedField<global::Person> people_ = new pbc::RepeatedField<global::Person>();
  public pbc::RepeatedField<global::Person> People {
    get { return people_; }
  }
  public override bool Equals(object other) {
    return Equals(other as AddressBook);
  }
  public bool Equals(AddressBook other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!people_.Equals(other.people_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }
  public override int GetHashCode() {
    int hash = 1;
    hash ^= people_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    people_.WriteTo(output, _repeated_people_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    people_.WriteTo(ref output, _repeated_people_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }

#endif
  public int CalculateSize() {
    int size = 0;
    size += people_.CalculateSize(_repeated_people_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }
  public void MergeFrom(AddressBook other) {
    if (other == null) {
      return;
    }
    people_.Add(other.people_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          people_.AddEntriesFrom(input, _repeated_people_codec);
          break;
        }
      }
    }
  #endif
  }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          people_.AddEntriesFrom(ref input, _repeated_people_codec);
          break;
        }
      }
    }
  }
  #endif

}

public sealed partial class AnotherThing : pb::IMessage<AnotherThing>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<AnotherThing> _parser = new pb::MessageParser<AnotherThing>(() => new AnotherThing());
  private pb::UnknownFieldSet _unknownFields;
  private int _hasBits0;
  public static pb::MessageParser<AnotherThing> Parser { get { return _parser; } }
  public static pbr::MessageDescriptor Descriptor {
    get { return global::AddressBookReflection.Descriptor.MessageTypes[2]; }
  }
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }
  public AnotherThing() {
    OnConstruction();
  }

  partial void OnConstruction();
  public AnotherThing(AnotherThing other) : this() {
    _hasBits0 = other._hasBits0;
    name_ = other.name_;
    id_ = other.id_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }
  public AnotherThing Clone() {
    return new AnotherThing(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private readonly static string NameDefaultValue = "";

  private string name_;
  public string Name {
    get { return name_ ?? NameDefaultValue; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }
  public bool HasName {
    get { return name_ != null; }
  }
  public void ClearName() {
    name_ = null;
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 2;
  private readonly static int IdDefaultValue = 0;

  private int id_;
  public int Id {
    get { if ((_hasBits0 & 1) != 0) { return id_; } else { return IdDefaultValue; } }
    set {
      _hasBits0 |= 1;
      id_ = value;
    }
  }
  public bool HasId {
    get { return (_hasBits0 & 1) != 0; }
  }
  public void ClearId() {
    _hasBits0 &= ~1;
  }
  public override bool Equals(object other) {
    return Equals(other as AnotherThing);
  }
  public bool Equals(AnotherThing other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (Id != other.Id) return false;
    return Equals(_unknownFields, other._unknownFields);
  }
  public override int GetHashCode() {
    int hash = 1;
    if (HasName) hash ^= Name.GetHashCode();
    if (HasId) hash ^= Id.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (HasName) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    if (HasId) {
      output.WriteRawTag(16);
      output.WriteInt32(Id);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (HasName) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    if (HasId) {
      output.WriteRawTag(16);
      output.WriteInt32(Id);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }

#endif
  public int CalculateSize() {
    int size = 0;
    if (HasName) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (HasId) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }
  public void MergeFrom(AnotherThing other) {
    if (other == null) {
      return;
    }
    if (other.HasName) {
      Name = other.Name;
    }
    if (other.HasId) {
      Id = other.Id;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Id = input.ReadInt32();
          break;
        }
      }
    }
  #endif
  }

#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Id = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
