<?xml version="1.0" encoding="utf-8"?>
<Dsl xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="65fc674b-a1ef-496d-8f44-a97e65134927" Description="Description for Ufba.ShHome.ShHome" Name="ShHome" DisplayName="Class Diagrams" Namespace="Ufba.ShHome" ProductName="ShHome" CompanyName="Ufba" PackageGuid="77ffa719-c0b9-4ca6-be18-1ca75620562f" PackageNamespace="Ufba.ShHome" xmlns="http://schemas.microsoft.com/VisualStudio/2005/DslTools/DslDefinitionModel">
  <Classes>
    <DomainClass Id="e0be5be1-3d03-4c20-8d94-df0429281519" Description="" Name="ModelRoot" DisplayName="Model Root" Namespace="Ufba.ShHome">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Comment" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>ModelRootHasComments.Comments</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="ModelType" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>ModelRootHasTypes.Types</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Device" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>ModelHasDevices.Devices</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="381ea111-fcf2-4b57-b08f-87e37122b4db" Description="" Name="ModelClass" DisplayName="Model Class" Namespace="Ufba.ShHome">
      <BaseClass>
        <DomainClassMoniker Name="ModelType" />
      </BaseClass>
      <Properties>
        <DomainProperty Id="8005df81-3e86-4f6d-9bbd-54ed3bbd34de" Description="" Name="Name" DisplayName="Name" DefaultValue="">
          <Type>
            <DomainEnumerationMoniker Name="NameFeature" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="143e82e0-a08a-4fb4-8a21-9b0633878971" Description="Description for Ufba.ShHome.ModelClass.Type Feature" Name="TypeFeature" DisplayName="Type Feature">
          <Type>
            <DomainEnumerationMoniker Name="TypeFeature" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="bce70a21-cde2-4743-8ac1-68ad80be4c68" Description="Description for Ufba.ShHome.ModelClass.Serial" Name="Serial" DisplayName="Serial">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="4284669d-6579-48a6-8f26-01a7b4be76d1" Description="" Name="Comment" DisplayName="Comment" Namespace="Ufba.ShHome">
      <Properties>
        <DomainProperty Id="49a3f2b3-3522-4eab-b6ab-346016b43f99" Description="" Name="Text" DisplayName="Text" DefaultValue="">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
    <DomainClass Id="2ef705e6-eacb-4b79-b5f0-214f52aa74fc" Description="" Name="ModelType" DisplayName="Model Type" InheritanceModifier="Abstract" Namespace="Ufba.ShHome">
      <ElementMergeDirectives>
        <ElementMergeDirective>
          <Index>
            <DomainClassMoniker Name="Comment" />
          </Index>
          <LinkCreationPaths>
            <DomainPath>CommentReferencesSubjects.Comments</DomainPath>
            <DomainPath>ModelRootHasTypes.ModelRoot/!ModelRoot/ModelRootHasComments.Comments</DomainPath>
          </LinkCreationPaths>
        </ElementMergeDirective>
      </ElementMergeDirectives>
    </DomainClass>
    <DomainClass Id="08b1fe94-efc9-4944-8c54-037a147c9331" Description="Description for Ufba.ShHome.Device" Name="Device" DisplayName="Device" Namespace="Ufba.ShHome">
      <Properties>
        <DomainProperty Id="e36a8795-537d-4446-86cd-684817d55883" Description="Description for Ufba.ShHome.Device.Name" Name="Name" DisplayName="Name">
          <Type>
            <ExternalTypeMoniker Name="/System/String" />
          </Type>
        </DomainProperty>
        <DomainProperty Id="00270314-107d-481b-8975-fdef251139b8" Description="Description for Ufba.ShHome.Device.Type Device" Name="TypeDevice" DisplayName="Type Device">
          <Type>
            <DomainEnumerationMoniker Name="TypeDevice" />
          </Type>
        </DomainProperty>
      </Properties>
    </DomainClass>
  </Classes>
  <Relationships>
    <DomainRelationship Id="a21cfac0-57d7-423f-9331-e02f406905b8" Description="" Name="ModelRootHasComments" DisplayName="Model Root Has Comments" Namespace="Ufba.ShHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="9d2645e3-945b-48eb-a8b5-e5a88f1ca2cb" Description="" Name="ModelRoot" DisplayName="Model Root" PropertyName="Comments" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Comments">
          <RolePlayer>
            <DomainClassMoniker Name="ModelRoot" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="590a8a57-c219-405d-9d0a-abf8a1b9a323" Description="" Name="Comment" DisplayName="Comment" PropertyName="ModelRoot" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Model Root">
          <RolePlayer>
            <DomainClassMoniker Name="Comment" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="5a02d0cf-8aab-40e5-9405-f3c3c3cc5a27" Description="" Name="ModelRootHasTypes" DisplayName="Model Root Has Types" Namespace="Ufba.ShHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="feb179cb-09c8-4cac-a7c0-4c1190e428c0" Description="" Name="ModelRoot" DisplayName="Model Root" PropertyName="Types" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Types">
          <RolePlayer>
            <DomainClassMoniker Name="ModelRoot" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="37a1dc4d-5cfc-4e77-baea-6316f8c111ea" Description="" Name="Type" DisplayName="Type" PropertyName="ModelRoot" Multiplicity="ZeroOne" PropagatesDelete="true" PropertyDisplayName="">
          <RolePlayer>
            <DomainClassMoniker Name="ModelType" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="0744a2a1-261a-40e2-ad1d-d590a9f01abc" Description="" Name="CommentReferencesSubjects" DisplayName="Comment References Subjects" Namespace="Ufba.ShHome">
      <Source>
        <DomainRole Id="5f102ffd-9d32-4f2b-b1e8-cc6fc2555bc4" Description="" Name="Comment" DisplayName="Comment" PropertyName="Subjects" PropertyDisplayName="Subjects">
          <RolePlayer>
            <DomainClassMoniker Name="Comment" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="4f55a23a-7939-48b3-92a5-d13f26fb77fc" Description="" Name="Subject" DisplayName="Subject" PropertyName="Comments" PropertyDisplayName="Comments">
          <RolePlayer>
            <DomainClassMoniker Name="ModelType" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="5586c5ea-8b4a-466c-9d53-32fad4940d9e" Description="Description for Ufba.ShHome.ModelHasDevices" Name="ModelHasDevices" DisplayName="Model Has Devices" Namespace="Ufba.ShHome" IsEmbedding="true">
      <Source>
        <DomainRole Id="dc394f86-3538-4acd-a864-a7823756f6b5" Description="Description for Ufba.ShHome.ModelHasDevices.ModelRoot" Name="ModelRoot" DisplayName="Model Root" PropertyName="Devices" PropagatesCopy="PropagatesCopyToLinkAndOppositeRolePlayer" PropertyDisplayName="Devices">
          <RolePlayer>
            <DomainClassMoniker Name="ModelRoot" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="10ad6d90-0120-4e7d-99db-7717cbe97ef9" Description="Description for Ufba.ShHome.ModelHasDevices.Device" Name="Device" DisplayName="Device" PropertyName="ModelRoot" Multiplicity="One" PropagatesDelete="true" PropertyDisplayName="Model Root">
          <RolePlayer>
            <DomainClassMoniker Name="Device" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="432baed8-f41b-478e-9a6d-a9ab3b739c6d" Description="Description for Ufba.ShHome.ModelTypeReferencesActuator" Name="ModelTypeReferencesActuator" DisplayName="Model Type References Actuator" Namespace="Ufba.ShHome">
      <Source>
        <DomainRole Id="2121fa4e-9284-4b69-b6ae-692e6777a45e" Description="Description for Ufba.ShHome.ModelTypeReferencesActuator.ModelType" Name="ModelType" DisplayName="Model Type" PropertyName="Actuator" Multiplicity="One" PropertyDisplayName="Actuator">
          <RolePlayer>
            <DomainClassMoniker Name="ModelType" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="19a27655-d83b-40e6-be00-af56747636d6" Description="Description for Ufba.ShHome.ModelTypeReferencesActuator.Device" Name="Device" DisplayName="Device" PropertyName="FeatureHasActuator" Multiplicity="OneMany" PropertyDisplayName="Feature Has Actuator">
          <RolePlayer>
            <DomainClassMoniker Name="Device" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
    <DomainRelationship Id="c8a4242b-72a8-48ed-aff4-0e859002bda0" Description="Description for Ufba.ShHome.ModelTypeReferencesSensor" Name="ModelTypeReferencesSensor" DisplayName="Model Type References Sensor" Namespace="Ufba.ShHome">
      <Source>
        <DomainRole Id="44ce0027-5065-42ee-9e06-561a5adb61ac" Description="Description for Ufba.ShHome.ModelTypeReferencesSensor.ModelType" Name="ModelType" DisplayName="Model Type" PropertyName="Sensor" Multiplicity="ZeroOne" PropertyDisplayName="Sensor">
          <RolePlayer>
            <DomainClassMoniker Name="ModelType" />
          </RolePlayer>
        </DomainRole>
      </Source>
      <Target>
        <DomainRole Id="21c8fb67-aa3c-4fa1-809e-c2060caa2616" Description="Description for Ufba.ShHome.ModelTypeReferencesSensor.Device" Name="Device" DisplayName="Device" PropertyName="FeatureHasSensor" Multiplicity="OneMany" PropertyDisplayName="Feature Has Sensor">
          <RolePlayer>
            <DomainClassMoniker Name="Device" />
          </RolePlayer>
        </DomainRole>
      </Target>
    </DomainRelationship>
  </Relationships>
  <Types>
    <ExternalType Name="DateTime" Namespace="System" />
    <ExternalType Name="String" Namespace="System" />
    <ExternalType Name="Int16" Namespace="System" />
    <ExternalType Name="Int32" Namespace="System" />
    <ExternalType Name="Int64" Namespace="System" />
    <ExternalType Name="UInt16" Namespace="System" />
    <ExternalType Name="UInt32" Namespace="System" />
    <ExternalType Name="UInt64" Namespace="System" />
    <ExternalType Name="SByte" Namespace="System" />
    <ExternalType Name="Byte" Namespace="System" />
    <ExternalType Name="Double" Namespace="System" />
    <ExternalType Name="Single" Namespace="System" />
    <ExternalType Name="Guid" Namespace="System" />
    <ExternalType Name="Boolean" Namespace="System" />
    <ExternalType Name="Char" Namespace="System" />
    <DomainEnumeration Name="AccessModifier" Namespace="Ufba.ShHome" Description="">
      <Literals>
        <EnumerationLiteral Description="" Name="Public" Value="0" />
        <EnumerationLiteral Description="" Name="Assembly" Value="1" />
        <EnumerationLiteral Description="" Name="Private" Value="2" />
        <EnumerationLiteral Description="" Name="Family" Value="3" />
        <EnumerationLiteral Description="" Name="FamilyOrAssembly" Value="4" />
        <EnumerationLiteral Description="" Name="FamilyAndAssembly" Value="5" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="TypeAccessModifier" Namespace="Ufba.ShHome" Description="">
      <Literals>
        <EnumerationLiteral Description="" Name="Public" Value="0" />
        <EnumerationLiteral Description="" Name="Private" Value="1" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="InheritanceModifier" Namespace="Ufba.ShHome" Description="">
      <Literals>
        <EnumerationLiteral Description="" Name="None" Value="0" />
        <EnumerationLiteral Description="" Name="Abstract" Value="1" />
        <EnumerationLiteral Description="" Name="Sealed" Value="2" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="Multiplicity" Namespace="Ufba.ShHome" Description="">
      <Literals>
        <EnumerationLiteral Description="" Name="ZeroMany" Value="0" />
        <EnumerationLiteral Description="" Name="One" Value="1" />
        <EnumerationLiteral Description="" Name="ZeroOne" Value="2" />
        <EnumerationLiteral Description="" Name="OneMany" Value="3" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="OperationConcurrency" Namespace="Ufba.ShHome" Description="">
      <Literals>
        <EnumerationLiteral Description="" Name="Sequential" Value="0" />
        <EnumerationLiteral Description="" Name="Guarded" Value="1" />
        <EnumerationLiteral Description="" Name="Concurrent" Value="2" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="TypeFeature" Namespace="Ufba.ShHome" Description="Description for Ufba.ShHome.TypeFeature">
      <Literals>
        <EnumerationLiteral Description="Description for Ufba.ShHome.TypeFeature.Mandatory" Name="Mandatory" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.TypeFeature.EnumerationLiteral2" Name="EnumerationLiteral2" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.TypeFeature.OR" Name="OR" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.TypeFeature.Optional" Name="Optional" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.TypeFeature.Alternative" Name="Alternative" Value="" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="TypeDevice" Namespace="Ufba.ShHome" Description="Description for Ufba.ShHome.TypeDevice">
      <Literals>
        <EnumerationLiteral Description="Description for Ufba.ShHome.TypeDevice.Actuator" Name="Actuator" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.TypeDevice.Sensor" Name="Sensor" Value="" />
      </Literals>
    </DomainEnumeration>
    <DomainEnumeration Name="NameFeature" Namespace="Ufba.ShHome" Description="Description for Ufba.ShHome.NameFeature">
      <Literals>
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.UserAirConditionerControl" Name="UserAirConditionerControl" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.PresenceIlusion" Name="PresenceIlusion" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.UserWindowControl" Name="UserWindowControl" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.AutomatedWindowControl" Name="AutomatedWindowControl" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.AutomatedIluminationByLuminosity" Name="AutomatedIluminationByLuminosity" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.UserIlumination" Name="UserIlumination" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.AutomatedIluminationByPresence" Name="AutomatedIluminationByPresence" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.AutomatedAirConditionerControl" Name="AutomatedAirConditionerControl" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.LockDoors" Name="LockDoors" Value="" />
        <EnumerationLiteral Description="Description for Ufba.ShHome.NameFeature.AlarmAgainstRobbery" Name="AlarmAgainstRobbery" Value="" />
      </Literals>
    </DomainEnumeration>
  </Types>
  <Shapes>
    <GeometryShape Id="f8a9826d-feac-4884-9a74-917b85bab175" Description="" Name="CommentBoxShape" DisplayName="Comment Box Shape" Namespace="Ufba.ShHome" FixedTooltipText="Comment Box Shape" FillColor="255, 255, 204" OutlineColor="204, 204, 102" InitialHeight="0.3" OutlineThickness="0.01" FillGradientMode="None" Geometry="Rectangle">
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Comment" DisplayName="Comment" DefaultText="BusinessRulesShapeNameDecorator" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="fbc21c43-dc5b-43c6-99e4-7b6c63a64506" Description="Description for Ufba.ShHome.DeviceShape" Name="DeviceShape" DisplayName="Device Shape" Namespace="Ufba.ShHome" FixedTooltipText="Device Shape" InitialHeight="1" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerTopLeft" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="TypeDevice" DisplayName="Type Device" DefaultText="TypeDevice" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="ee96fc9d-3b9e-4398-8082-ec9f23cc7c88" Description="Description for Ufba.ShHome.FShape" Name="FShape" DisplayName="FShape" Namespace="Ufba.ShHome" FixedTooltipText="FShape" FillColor="192, 255, 255" InitialHeight="0.8" Geometry="RoundedRectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="TypeFeature" DisplayName="Type Feature" DefaultText="TypeFeature" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="InnerBottomCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Serial" DisplayName="Serial" DefaultText="Serial" />
      </ShapeHasDecorators>
    </GeometryShape>
    <GeometryShape Id="64ae7ae5-2a71-432b-9065-edc05e56e58a" Description="Description for Ufba.ShHome.DShape" Name="DShape" DisplayName="DShape" Namespace="Ufba.ShHome" FixedTooltipText="DShape" FillColor="255, 192, 128" InitialHeight="0.5" Geometry="Rectangle">
      <ShapeHasDecorators Position="InnerTopCenter" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="Name" DisplayName="Name" DefaultText="Name" />
      </ShapeHasDecorators>
      <ShapeHasDecorators Position="Center" HorizontalOffset="0" VerticalOffset="0">
        <TextDecorator Name="TypeDevice" DisplayName="Type Device" DefaultText="TypeDevice" />
      </ShapeHasDecorators>
    </GeometryShape>
  </Shapes>
  <Connectors>
    <Connector Id="6c2cbcc9-1c05-49ce-b1e9-b0fe3b2a7803" Description="" Name="CommentConnector" DisplayName="Comment Connector" Namespace="Ufba.ShHome" FixedTooltipText="Comment Connector" Color="113, 111, 110" DashStyle="Dot" Thickness="0.01" RoutingStyle="Straight" />
    <Connector Id="6450202c-4c1c-41df-9326-c65c3cb41719" Description="Description for Ufba.ShHome.ActuatorConnector" Name="ActuatorConnector" DisplayName="Actuator Connector" Namespace="Ufba.ShHome" FixedTooltipText="Actuator Connector" />
    <Connector Id="f2dadd51-e785-41c8-89d3-48a1f6a115a5" Description="Description for Ufba.ShHome.SConnector" Name="SConnector" DisplayName="SConnector" Namespace="Ufba.ShHome" FixedTooltipText="SConnector" DashStyle="Dot" />
  </Connectors>
  <XmlSerializationBehavior Name="ShHomeSerializationBehavior" Namespace="Ufba.ShHome">
    <ClassData>
      <XmlClassData TypeName="ModelRootHasComments" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelRootHasCommentsMoniker" ElementName="modelRootHasComments" MonikerTypeName="ModelRootHasCommentsMoniker">
        <DomainRelationshipMoniker Name="ModelRootHasComments" />
      </XmlClassData>
      <XmlClassData TypeName="ModelRootHasTypes" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelRootHasTypesMoniker" ElementName="modelRootHasTypes" MonikerTypeName="ModelRootHasTypesMoniker">
        <DomainRelationshipMoniker Name="ModelRootHasTypes" />
      </XmlClassData>
      <XmlClassData TypeName="CommentReferencesSubjects" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentReferencesSubjectsMoniker" ElementName="commentReferencesSubjects" MonikerTypeName="CommentReferencesSubjectsMoniker">
        <DomainRelationshipMoniker Name="CommentReferencesSubjects" />
      </XmlClassData>
      <XmlClassData TypeName="ModelRoot" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelRootMoniker" ElementName="modelRoot" MonikerTypeName="ModelRootMoniker">
        <DomainClassMoniker Name="ModelRoot" />
        <ElementData>
          <XmlRelationshipData RoleElementName="comments">
            <DomainRelationshipMoniker Name="ModelRootHasComments" />
          </XmlRelationshipData>
          <XmlRelationshipData RoleElementName="types">
            <DomainRelationshipMoniker Name="ModelRootHasTypes" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="devices">
            <DomainRelationshipMoniker Name="ModelHasDevices" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ModelClass" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelClassMoniker" ElementName="modelClass" MonikerTypeName="ModelClassMoniker">
        <DomainClassMoniker Name="ModelClass" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="ModelClass/Name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="typeFeature">
            <DomainPropertyMoniker Name="ModelClass/TypeFeature" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="serial">
            <DomainPropertyMoniker Name="ModelClass/Serial" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="Comment" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentMoniker" ElementName="comment" MonikerTypeName="CommentMoniker">
        <DomainClassMoniker Name="Comment" />
        <ElementData>
          <XmlPropertyData XmlName="text">
            <DomainPropertyMoniker Name="Comment/Text" />
          </XmlPropertyData>
          <XmlRelationshipData RoleElementName="subjects">
            <DomainRelationshipMoniker Name="CommentReferencesSubjects" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ModelType" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelTypeMoniker" ElementName="modelType" MonikerTypeName="ModelTypeMoniker">
        <DomainClassMoniker Name="ModelType" />
        <ElementData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="actuator">
            <DomainRelationshipMoniker Name="ModelTypeReferencesActuator" />
          </XmlRelationshipData>
          <XmlRelationshipData UseFullForm="true" RoleElementName="sensor">
            <DomainRelationshipMoniker Name="ModelTypeReferencesSensor" />
          </XmlRelationshipData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="CommentBoxShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentBoxShapeMoniker" ElementName="commentBoxShape" MonikerTypeName="CommentBoxShapeMoniker">
        <GeometryShapeMoniker Name="CommentBoxShape" />
      </XmlClassData>
      <XmlClassData TypeName="CommentConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="commentConnectorMoniker" ElementName="commentConnector" MonikerTypeName="CommentConnectorMoniker">
        <ConnectorMoniker Name="CommentConnector" />
      </XmlClassData>
      <XmlClassData TypeName="ShHomeDiagram" MonikerAttributeName="" SerializeId="true" MonikerElementName="shHomeDiagramMoniker" ElementName="shHomeDiagram" MonikerTypeName="ShHomeDiagramMoniker">
        <DiagramMoniker Name="ShHomeDiagram" />
      </XmlClassData>
      <XmlClassData TypeName="Device" MonikerAttributeName="" SerializeId="true" MonikerElementName="deviceMoniker" ElementName="device" MonikerTypeName="DeviceMoniker">
        <DomainClassMoniker Name="Device" />
        <ElementData>
          <XmlPropertyData XmlName="name">
            <DomainPropertyMoniker Name="Device/Name" />
          </XmlPropertyData>
          <XmlPropertyData XmlName="typeDevice">
            <DomainPropertyMoniker Name="Device/TypeDevice" />
          </XmlPropertyData>
        </ElementData>
      </XmlClassData>
      <XmlClassData TypeName="ModelHasDevices" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelHasDevicesMoniker" ElementName="modelHasDevices" MonikerTypeName="ModelHasDevicesMoniker">
        <DomainRelationshipMoniker Name="ModelHasDevices" />
      </XmlClassData>
      <XmlClassData TypeName="DeviceShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="deviceShapeMoniker" ElementName="deviceShape" MonikerTypeName="DeviceShapeMoniker">
        <GeometryShapeMoniker Name="DeviceShape" />
      </XmlClassData>
      <XmlClassData TypeName="ActuatorConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="actuatorConnectorMoniker" ElementName="actuatorConnector" MonikerTypeName="ActuatorConnectorMoniker">
        <ConnectorMoniker Name="ActuatorConnector" />
      </XmlClassData>
      <XmlClassData TypeName="ModelTypeReferencesActuator" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelTypeReferencesActuatorMoniker" ElementName="modelTypeReferencesActuator" MonikerTypeName="ModelTypeReferencesActuatorMoniker">
        <DomainRelationshipMoniker Name="ModelTypeReferencesActuator" />
      </XmlClassData>
      <XmlClassData TypeName="ModelTypeReferencesSensor" MonikerAttributeName="" SerializeId="true" MonikerElementName="modelTypeReferencesSensorMoniker" ElementName="modelTypeReferencesSensor" MonikerTypeName="ModelTypeReferencesSensorMoniker">
        <DomainRelationshipMoniker Name="ModelTypeReferencesSensor" />
      </XmlClassData>
      <XmlClassData TypeName="FShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="fShapeMoniker" ElementName="fShape" MonikerTypeName="FShapeMoniker">
        <GeometryShapeMoniker Name="FShape" />
      </XmlClassData>
      <XmlClassData TypeName="DShape" MonikerAttributeName="" SerializeId="true" MonikerElementName="dShapeMoniker" ElementName="dShape" MonikerTypeName="DShapeMoniker">
        <GeometryShapeMoniker Name="DShape" />
      </XmlClassData>
      <XmlClassData TypeName="SConnector" MonikerAttributeName="" SerializeId="true" MonikerElementName="sConnectorMoniker" ElementName="sConnector" MonikerTypeName="SConnectorMoniker">
        <ConnectorMoniker Name="SConnector" />
      </XmlClassData>
    </ClassData>
  </XmlSerializationBehavior>
  <ExplorerBehavior Name="ShHomeExplorer" />
  <ConnectionBuilders>
    <ConnectionBuilder Name="CommentReferencesSubjectsBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="CommentReferencesSubjects" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Comment" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ModelClass" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="ModelTypeReferencesActuatorBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="ModelTypeReferencesActuator" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ModelType" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Device" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
    <ConnectionBuilder Name="ModelTypeReferencesSensorBuilder">
      <LinkConnectDirective>
        <DomainRelationshipMoniker Name="ModelTypeReferencesSensor" />
        <SourceDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="ModelType" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </SourceDirectives>
        <TargetDirectives>
          <RolePlayerConnectDirective>
            <AcceptingClass>
              <DomainClassMoniker Name="Device" />
            </AcceptingClass>
          </RolePlayerConnectDirective>
        </TargetDirectives>
      </LinkConnectDirective>
    </ConnectionBuilder>
  </ConnectionBuilders>
  <Diagram Id="0295f857-8e0d-4231-a209-2fd2b139cc3c" Description="" Name="ShHomeDiagram" DisplayName="Class Diagram" Namespace="Ufba.ShHome">
    <Class>
      <DomainClassMoniker Name="ModelRoot" />
    </Class>
    <ShapeMaps>
      <ShapeMap>
        <DomainClassMoniker Name="Comment" />
        <ParentElementPath>
          <DomainPath>ModelRootHasComments.ModelRoot/!ModelRoot</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="CommentBoxShape/Comment" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Comment/Text" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="CommentBoxShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="ModelClass" />
        <ParentElementPath>
          <DomainPath>ModelRootHasTypes.ModelRoot/!ModelRoot</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="FShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="ModelClass/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="FShape/TypeFeature" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="ModelClass/TypeFeature" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="FShape/Serial" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="ModelClass/Serial" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="FShape" />
      </ShapeMap>
      <ShapeMap>
        <DomainClassMoniker Name="Device" />
        <ParentElementPath>
          <DomainPath>ModelHasDevices.ModelRoot/!ModelRoot</DomainPath>
        </ParentElementPath>
        <DecoratorMap>
          <TextDecoratorMoniker Name="DShape/Name" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Device/Name" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <DecoratorMap>
          <TextDecoratorMoniker Name="DShape/TypeDevice" />
          <PropertyDisplayed>
            <PropertyPath>
              <DomainPropertyMoniker Name="Device/TypeDevice" />
            </PropertyPath>
          </PropertyDisplayed>
        </DecoratorMap>
        <GeometryShapeMoniker Name="DShape" />
      </ShapeMap>
    </ShapeMaps>
    <ConnectorMaps>
      <ConnectorMap>
        <ConnectorMoniker Name="CommentConnector" />
        <DomainRelationshipMoniker Name="CommentReferencesSubjects" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="ActuatorConnector" />
        <DomainRelationshipMoniker Name="ModelTypeReferencesActuator" />
      </ConnectorMap>
      <ConnectorMap>
        <ConnectorMoniker Name="SConnector" />
        <DomainRelationshipMoniker Name="ModelTypeReferencesSensor" />
      </ConnectorMap>
    </ConnectorMaps>
  </Diagram>
  <Designer CopyPasteGeneration="CopyPasteOnly" FileExtension="vShome" EditorGuid="0eb83710-3bb5-41eb-94d9-0d57d5ce3ca7">
    <RootClass>
      <DomainClassMoniker Name="ModelRoot" />
    </RootClass>
    <XmlSerializationDefinition CustomPostLoad="false">
      <XmlSerializationBehaviorMoniker Name="ShHomeSerializationBehavior" />
    </XmlSerializationDefinition>
    <ToolboxTab TabText="Class Diagrams">
      <ElementTool Name="ModelClass" ToolboxIcon="Resources\ClassTool.bmp" Caption="Class" Tooltip="Create a Class" HelpKeyword="ModelClassF1Keyword">
        <DomainClassMoniker Name="ModelClass" />
      </ElementTool>
      <ElementTool Name="Comment" ToolboxIcon="resources\commenttool.bmp" Caption="Comment" Tooltip="Create a Comment" HelpKeyword="CommentF1Keyword">
        <DomainClassMoniker Name="Comment" />
      </ElementTool>
      <ConnectionTool Name="CommentsReferenceTypes" ToolboxIcon="resources\commentlinktool.bmp" Caption="Comment Link" Tooltip="Link a comment to an element" HelpKeyword="CommentsReferenceTypesF1Keyword">
        <ConnectionBuilderMoniker Name="ShHome/CommentReferencesSubjectsBuilder" />
      </ConnectionTool>
      <ElementTool Name="Device" ToolboxIcon="C:\Users\ana.ufba\Documents\Visual Studio 2015\Projects\Language4\Dsl\Resources\ElementToolBitmap.bmp" Caption="Device" Tooltip="Device" HelpKeyword="Device">
        <DomainClassMoniker Name="Device" />
      </ElementTool>
      <ConnectionTool Name="Actuator" ToolboxIcon="C:\Users\ana.ufba\Documents\Visual Studio 2015\Projects\Language4\Dsl\Resources\FlowTool.bmp" Caption="Actuator" Tooltip="Actuator" HelpKeyword="Actuator">
        <ConnectionBuilderMoniker Name="ShHome/ModelTypeReferencesActuatorBuilder" />
      </ConnectionTool>
      <ConnectionTool Name="Sensor" ToolboxIcon="C:\Users\ana.ufba\Documents\Visual Studio 2015\Projects\Language4\Dsl\Resources\ObjectFlowTool.bmp" Caption="Sensor" Tooltip="Sensor" HelpKeyword="Sensor">
        <ConnectionBuilderMoniker Name="ShHome/ModelTypeReferencesSensorBuilder" />
      </ConnectionTool>
    </ToolboxTab>
    <Validation UsesMenu="false" UsesOpen="false" UsesSave="false" UsesLoad="false" />
    <DiagramMoniker Name="ShHomeDiagram" />
  </Designer>
  <Explorer ExplorerGuid="d0ca3013-ad3a-40eb-91f8-98480563e21f" Title="">
    <ExplorerBehaviorMoniker Name="ShHome/ShHomeExplorer" />
  </Explorer>
</Dsl>