namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext9 ContextSwitchInterpreter
								if(AddContext9 != null)
								{
									UnityEngine.Vector3 OperandVar19 = default(UnityEngine.Vector3); //IsContext = False IsNew = False
									System.Single OperandVar13 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar11 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop10 = External.MapX(); //IsContext = False IsNew = False
									OperandVar11 = prop10;
									System.Single prop12 = External.Random( (0f), (OperandVar11)); //IsContext = False IsNew = False
									OperandVar13 = prop12;
									System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
									
									System.Int32 OperandVar15 = default(System.Int32); //IsContext = False IsNew = False
									System.Int32 prop14 = External.MapX(); //IsContext = False IsNew = False
									OperandVar15 = prop14;
									System.Single prop16 = External.Random( (0f), (OperandVar15)); //IsContext = False IsNew = False
									OperandVar17 = prop16;
									UnityEngine.Vector3 prop18 = External.Vec( (OperandVar13), (OperandVar17)); //IsContext = False IsNew = False
									OperandVar19 = prop18;
									AddContext9.Position = (UnityEngine.Vector3)( (OperandVar19));
								}
							}
							Place AddContext20 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext20 ContextSwitchInterpreter
								if(AddContext20 != null)
								{
									System.Single OperandVar22 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop21 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar22 = prop21;
									AddContext20.Size = (System.Int32)( (OperandVar22));
								}
							}
							Markers AddContext23 = (Markers)loc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Markers AddContext23 ContextSwitchInterpreter
								if(AddContext23 != null)
								{
									System.String OperandVar24 = default(System.String); //IsContext = False IsNew = False
									OperandVar24 = "history_place";
									AddContext23.SetMarker(( (OperandVar24)).ToString());
								}
							}
							Named AddContext25 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext25 ContextSwitchInterpreter
								if(AddContext25 != null)
								{
									
									
									
									AddContext25.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar28 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar26 = default(System.String); //IsContext = False IsNew = False
									OperandVar26 = "human_name";
									System.String prop27 = External.RandomName( (OperandVar26)); //IsContext = False IsNew = False
									if(prop27 != null)
									{
										OperandVar28 = prop27;
									}
									AddContext25.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar28)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar30 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable29 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable29 != null)
						{
							OperandVar30 = StoredVariable29;
						}
						subContext5.Attach((Place)( (OperandVar30)));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar44 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable31 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable31 != null)
			{
				Markers StoredVariable32 = ((Markers)StoredVariable31.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable32 != null)
				{
					System.Boolean ifResult33; //IsContext = False IsNew = False
					
					System.Boolean OperandVar40 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable31 != null)
					{
						UnityEngine.GameObject prop34 = StoredVariable31.ShowedObject; //IsContext = False IsNew = False
						if(prop34 != null)
						{
							System.Boolean ifResult35; //IsContext = False IsNew = False
							System.Boolean OperandVar39 = default(System.Boolean); //IsContext = False IsNew = False
							Named OperandVar37 = default(Named); //IsContext = False IsNew = False
							Named StoredVariable36 = ((Named)prop34.GetComponent(typeof(Named))); //IsContext = False IsNew = False
							if(StoredVariable36 != null)
							{
								OperandVar37 = StoredVariable36;
							}
							System.Boolean prop38 = External.Has( (OperandVar37)); //IsContext = False IsNew = False
							OperandVar39 = prop38;
							if(ifResult35 =  (OperandVar39))
							{
								OperandVar40 = ifResult35;
							}
						}
					}
					
					System.Boolean OperandVar43 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar41 = default(System.String); //IsContext = False IsNew = False
					OperandVar41 = "named_ui_marker";
					System.Boolean prop42 = StoredVariable32.HasMarker( (OperandVar41)); //IsContext = False IsNew = False
					OperandVar43 = prop42;
					if(ifResult33 = ( ( (OperandVar40))) && ( (!(OperandVar43))))
					{
						applicable = true;
						OperandVar44 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar44);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext45 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext45 ContextSwitchInterpreter
				if(subContext45 != null)
				{
					System.String OperandVar46 = default(System.String); //IsContext = False IsNew = False
					OperandVar46 = "named_ui_marker";
					subContext45.SetUiMarker(( (OperandVar46)).ToString());
				}
			}
			
			{
				UiObject subContext47 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext47 ContextSwitchInterpreter
				if(subContext47 != null)
				{
					Named OperandVar50 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop48 = subContext47.ShowedObject; //IsContext = False IsNew = False
					if(prop48 != null)
					{
						Named StoredVariable49 = ((Named)prop48.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable49 != null)
						{
							OperandVar50 = StoredVariable49;
						}
					}
					Named showed_named =  (OperandVar50); //IsContext = False IsNew = False
					TextField ContextVar51 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar51 ContextSwitchInterpreter
						if(ContextVar51 != null)
						{
							System.String OperandVar53 = default(System.String); //IsContext = False IsNew = False
							System.String prop52 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop52 != null)
							{
								OperandVar53 = prop52;
							}
							ContextVar51.Show(( (OperandVar53)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda54 = () => 
									{
										System.String OperandVar56 = default(System.String); //IsContext = False IsNew = False
										System.String prop55 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop55 != null)
										{
											OperandVar56 = prop55;
										}
										ContextVar51.Show(( (OperandVar56)).ToString());
									};
									showed_named.OnUpdate(Lambda54);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext57 = ContextVar51.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext57 ContextPropertySwitchInterpreter
								if(subContext57 != null)
								{
									
									subContext57.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
					Entity EntVar58 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					if(EntVar58 != null) EntVar58.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class place_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar72 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable59 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable59 != null)
			{
				UiObject StoredVariable60 = ((UiObject)StoredVariable59.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
				if(StoredVariable60 != null)
				{
					System.Boolean ifResult61; //IsContext = False IsNew = False
					
					System.Boolean OperandVar68 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop62 = StoredVariable60.ShowedObject; //IsContext = False IsNew = False
					if(prop62 != null)
					{
						System.Boolean ifResult63; //IsContext = False IsNew = False
						System.Boolean OperandVar67 = default(System.Boolean); //IsContext = False IsNew = False
						Place OperandVar65 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable64 = ((Place)prop62.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable64 != null)
						{
							OperandVar65 = StoredVariable64;
						}
						System.Boolean prop66 = External.Has( (OperandVar65)); //IsContext = False IsNew = False
						OperandVar67 = prop66;
						if(ifResult63 =  (OperandVar67))
						{
							OperandVar68 = ifResult63;
						}
					}
					
					System.Boolean OperandVar71 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar69 = default(System.String); //IsContext = False IsNew = False
					OperandVar69 = "place_ui_set";
					System.Boolean prop70 = StoredVariable59.HasMarker( (OperandVar69)); //IsContext = False IsNew = False
					OperandVar71 = prop70;
					if(ifResult61 = ( ( (OperandVar68))) && ( (!(OperandVar71))))
					{
						applicable = true;
						OperandVar72 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar72);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext73 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext73 ContextSwitchInterpreter
				if(subContext73 != null)
				{
					System.String OperandVar74 = default(System.String); //IsContext = False IsNew = False
					OperandVar74 = "place_ui_set";
					subContext73.SetUiMarker(( (OperandVar74)).ToString());
				}
			}
			
			{
				UiObject subContext75 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext75 ContextSwitchInterpreter
				if(subContext75 != null)
				{
					Place OperandVar78 = default(Place); //IsContext = False IsNew = False
					UnityEngine.GameObject prop76 = subContext75.ShowedObject; //IsContext = False IsNew = False
					if(prop76 != null)
					{
						Place StoredVariable77 = ((Place)prop76.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable77 != null)
						{
							OperandVar78 = StoredVariable77;
						}
					}
					Place pl =  (OperandVar78); //IsContext = False IsNew = False
					Blackboards.place_ui_data puidata = root.AddComponent<Blackboards.place_ui_data>();; //IsContext = False IsNew = True
					Entity EntVar79 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
					
					
					{
						//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
						if(puidata != null)
						{
							System.Int32 OperandVar81 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop80 = pl.Size; //IsContext = False IsNew = False
							OperandVar81 = prop80;
							puidata.LastSize = (System.Int32)( (OperandVar81));
						}
					}
					TextField ContextVar82 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar82 ContextSwitchInterpreter
						if(ContextVar82 != null)
						{
							System.Int32 OperandVar84 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop83 = pl.Size; //IsContext = False IsNew = False
							OperandVar84 = prop83;
							ContextVar82.Show(( (OperandVar84)).ToString());
							System.Boolean OperandVar88 = default(System.Boolean); //IsContext = False IsNew = False
							Updated OperandVar86 = default(Updated); //IsContext = False IsNew = False
							Updated StoredVariable85 = ((Updated)ContextVar82.GetComponent(typeof(Updated))); //IsContext = False IsNew = False
							if(StoredVariable85 != null)
							{
								OperandVar86 = StoredVariable85;
							}
							System.Boolean prop87 = External.Has( (OperandVar86)); //IsContext = False IsNew = False
							OperandVar88 = prop87;
							if(!(OperandVar88))
							{
								root.AddComponent<Updated>();
								
							}
							
							{
								//ContextStatement TextField ContextVar82 ContextSwitchInterpreter
								if(ContextVar82 != null)
								{
									
									ContextVar82.Label = (System.String)( ("size"));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext89 = ContextVar82.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext89 ContextPropertySwitchInterpreter
								if(subContext89 != null)
								{
									
									subContext89.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								Updated subContext90 = (Updated)root.GetComponent(typeof(Updated)); //IsContext = True IsNew = False
								//ContextStatement Updated subContext90 ContextSwitchInterpreter
								if(subContext90 != null)
								{
									BoolDelegate Lambda91 = () => 
									{
										System.Boolean return_value = default(System.Boolean); //IsContext = False IsNew = False
										
										{
											//ContextStatement Place pl ContextSwitchInterpreter
											if(pl != null)
											{
												
												{
													//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
													if(puidata != null)
													{
														
														
														System.Int32 OperandVar93 = default(System.Int32); //IsContext = False IsNew = False
														if(pl != null)
														{
															System.Int32 prop92 = pl.Size; //IsContext = False IsNew = False
															OperandVar93 = prop92;
														}
														
														System.Int32 OperandVar95 = default(System.Int32); //IsContext = False IsNew = False
														if(puidata != null)
														{
															System.Int32 prop94 = puidata.LastSize; //IsContext = False IsNew = False
															OperandVar95 = prop94;
														}
														if(!(( ( (OperandVar93))) == ( ( (OperandVar95)))))
														{
															System.Int32 OperandVar97 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop96 = pl.Size; //IsContext = False IsNew = False
																OperandVar97 = prop96;
															}
															puidata.LastSize = (System.Int32)( (OperandVar97));
															System.Int32 OperandVar99 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop98 = pl.Size; //IsContext = False IsNew = False
																OperandVar99 = prop98;
															}
															ContextVar82.Show(( (OperandVar99)).ToString());
														}
													}
												}
											}
										}
										return return_value;
									};
									subContext90.OnUpdate(Lambda91);
								}
							}
						}
					}
					if(EntVar79 != null) EntVar79.ComponentAdded();
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar108 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable100 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable100 != null)
			{
				Place StoredVariable101 = ((Place)StoredVariable100.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable101 != null)
				{
					System.Boolean ifResult102; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar104 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop103 = StoredVariable101.Agents; //IsContext = False IsNew = False
					if(prop103 != null)
					{
						OperandVar104 = prop103;
					}
					
					
					
					System.Boolean OperandVar107 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar105 = default(System.String); //IsContext = False IsNew = False
					OperandVar105 = "agents_pool";
					System.Boolean prop106 = StoredVariable100.HasMarker( (OperandVar105)); //IsContext = False IsNew = False
					OperandVar107 = prop106;
					if(ifResult102 = ( (( ( (OperandVar104 != null ? OperandVar104.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar107))))
					{
						applicable = true;
						OperandVar108 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar108);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext109 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext109 ContextSwitchInterpreter
				if(subContext109 != null)
				{
					
					subContext109.Size = (System.Int32)( (5f));
					System.Single OperandVar111 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop110 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar111 = prop110;
					for (int i = 0; i <  (OperandVar111); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag112 = ag; //IsContext = True IsNew = False
							Entity AddContext113 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext114 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext115 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext115 ContextSwitchInterpreter
								if(AddContext115 != null)
								{
									System.Single OperandVar117 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop116 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar117 = prop116;
									AddContext115.Age = (System.Int32)( (OperandVar117));
								}
							}
							Named AddContext118 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext118 ContextSwitchInterpreter
								if(AddContext118 != null)
								{
									
									
									
									AddContext118.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar121 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar119 = default(System.String); //IsContext = False IsNew = False
									OperandVar119 = "human_name";
									System.String prop120 = External.RandomName( (OperandVar119)); //IsContext = False IsNew = False
									if(prop120 != null)
									{
										OperandVar121 = prop120;
									}
									AddContext118.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar121)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar123 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable122 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable122 != null)
						{
							OperandVar123 = StoredVariable122;
						}
						subContext109.Attach((Agent)( (OperandVar123)));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar130 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable124 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable124 != null)
			{
				System.Boolean ifResult125; //IsContext = False IsNew = False
				System.Boolean OperandVar129 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar127 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable126 = ((Blackboards.event_marker)StoredVariable124.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable126 != null)
				{
					OperandVar127 = StoredVariable126;
				}
				System.Boolean prop128 = External.Has( (OperandVar127)); //IsContext = False IsNew = False
				OperandVar129 = prop128;
				if(ifResult125 = !(OperandVar129))
				{
					applicable = true;
					OperandVar130 = applicable;
				}
			}
			return (System.Boolean) (OperandVar130);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
			Entity EntVar131 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar131 != null) EntVar131.ComponentAdded();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar138 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable132 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable132 != null)
			{
				System.Boolean ifResult133; //IsContext = False IsNew = False
				System.Boolean OperandVar137 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar135 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable134 = ((Blackboards.personality)StoredVariable132.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable134 != null)
				{
					OperandVar135 = StoredVariable134;
				}
				System.Boolean prop136 = External.Has( (OperandVar135)); //IsContext = False IsNew = False
				OperandVar137 = prop136;
				if(ifResult133 = !(OperandVar137))
				{
					applicable = true;
					OperandVar138 = applicable;
				}
			}
			return (System.Boolean) (OperandVar138);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
			Entity EntVar139 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar139 != null) EntVar139.ComponentAdded();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar146 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable140 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable140 != null)
			{
				System.Boolean ifResult141; //IsContext = False IsNew = False
				System.Boolean OperandVar145 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar143 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable142 = ((Blackboards.aged_generation)StoredVariable140.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable142 != null)
				{
					OperandVar143 = StoredVariable142;
				}
				System.Boolean prop144 = External.Has( (OperandVar143)); //IsContext = False IsNew = False
				OperandVar145 = prop144;
				if(ifResult141 = !(OperandVar145))
				{
					applicable = true;
					OperandVar146 = applicable;
				}
			}
			return (System.Boolean) (OperandVar146);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
			Entity EntVar147 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar147 != null) EntVar147.ComponentAdded();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar157 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable148 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable148 != null)
			{
				Lore StoredVariable149 = ((Lore)StoredVariable148.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable149 != null)
				{
					Place StoredVariable150 = ((Place)StoredVariable149.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable150 != null)
					{
						System.Boolean ifResult151; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar153 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop152 = StoredVariable150.Agents; //IsContext = False IsNew = False
						if(prop152 != null)
						{
							OperandVar153 = prop152;
						}
						
						
						
						System.Boolean OperandVar156 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar154 = default(System.String); //IsContext = False IsNew = False
						OperandVar154 = "lore_pool";
						System.Boolean prop155 = StoredVariable148.HasMarker( (OperandVar154)); //IsContext = False IsNew = False
						OperandVar156 = prop155;
						if(ifResult151 = ( (( ( (OperandVar153 != null ? OperandVar153.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar156))))
						{
							applicable = true;
							OperandVar157 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar157);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext158 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext158 ContextSwitchInterpreter
				if(subContext158 != null)
				{
					
					subContext158.Size = (System.Int32)( (10f));
					System.Single OperandVar160 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop159 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar160 = prop159;
					for (int i = 0; i <  (OperandVar160); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag161 = old_ag; //IsContext = True IsNew = False
							Entity AddContext162 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							Agent AddContext163 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext164 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext165 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext165 ContextSwitchInterpreter
								if(AddContext165 != null)
								{
									System.Single OperandVar167 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop166 = External.Random( (30f), (45f)); //IsContext = False IsNew = False
									OperandVar167 = prop166;
									AddContext165.Age = (System.Int32)( (OperandVar167));
								}
							}
							Named AddContext168 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext168 ContextSwitchInterpreter
								if(AddContext168 != null)
								{
									
									
									
									AddContext168.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar171 = default(System.String); //IsContext = False IsNew = False
									System.String OperandVar169 = default(System.String); //IsContext = False IsNew = False
									OperandVar169 = "human_name";
									System.String prop170 = External.RandomName( (OperandVar169)); //IsContext = False IsNew = False
									if(prop170 != null)
									{
										OperandVar171 = prop170;
									}
									AddContext168.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar171)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar173 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable172 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable172 != null)
						{
							OperandVar173 = StoredVariable172;
						}
						subContext158.Attach((Agent)( (OperandVar173)));
					}
				}
			}
		}
        }
    }
    
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar179 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable174 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable174 != null)
			{
				Named StoredVariable175 = ((Named)StoredVariable174.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable175 != null)
				{
					System.Boolean ifResult176; //IsContext = False IsNew = False
					
					System.Boolean OperandVar178 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable174 != null)
					{
						System.Boolean prop177 = StoredVariable174.Act; //IsContext = False IsNew = False
						OperandVar178 = prop177;
					}
					
					
					if(ifResult176 = ( ( (OperandVar178))) == ( ( (true))))
					{
						applicable = true;
						OperandVar179 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar179);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar183 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable180 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable180 != null)
			{
				System.String OperandVar181 = default(System.String); //IsContext = False IsNew = False
				OperandVar181 = "main_name";
				System.String prop182 = StoredVariable180.Get( (OperandVar181)); //IsContext = False IsNew = False
				if(prop182 != null)
				{
					OperandVar183 = prop182;
				}
			}
			External.Log((System.Object)( (OperandVar183)));
		}
        }
    }
    
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar191 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable184 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable184 != null)
			{
				Agent StoredVariable185 = ((Agent)StoredVariable184.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable185 != null)
				{
					System.Boolean ifResult186; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar188 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop187 = StoredVariable185.Act; //IsContext = False IsNew = False
					OperandVar188 = prop187;
					
					
					
					System.Boolean OperandVar190 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable184 != null)
					{
						System.Boolean prop189 = StoredVariable184.Dead; //IsContext = False IsNew = False
						OperandVar190 = prop189;
					}
					if(ifResult186 = ( (( ( (OperandVar188))) == ( ( (true))))) && ( (!(OperandVar190))))
					{
						applicable = true;
						OperandVar191 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar191);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.01f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar192 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar192 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar192)))));
			UnityEngine.GameObject OperandVar193 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar193 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar193)));
		}
        }
    }
    
    public class story_start : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar202 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable194 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable194 != null)
			{
				System.Boolean ifResult195; //IsContext = False IsNew = False
				
				System.Boolean OperandVar198 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar196 = default(System.String); //IsContext = False IsNew = False
				OperandVar196 = "init_node";
				System.Boolean prop197 = StoredVariable194.HasMarker( (OperandVar196)); //IsContext = False IsNew = False
				OperandVar198 = prop197;
				
				System.Boolean OperandVar201 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar199 = default(System.String); //IsContext = False IsNew = False
				OperandVar199 = "story_set";
				System.Boolean prop200 = StoredVariable194.HasMarker( (OperandVar199)); //IsContext = False IsNew = False
				OperandVar201 = prop200;
				if(ifResult195 = ( ( (OperandVar198))) && ( (!(OperandVar201))))
				{
					applicable = true;
					OperandVar202 = applicable;
				}
			}
			return (System.Boolean) (OperandVar202);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext203 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext203 ContextSwitchInterpreter
				if(subContext203 != null)
				{
					System.String OperandVar204 = default(System.String); //IsContext = False IsNew = False
					OperandVar204 = "story_set";
					subContext203.SetMarker(( (OperandVar204)).ToString());
				}
			}
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node205 = s_node; //IsContext = True IsNew = False
				TaleNode AddContext206 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.story_node AddContext207 = (Blackboards.story_node)s_node.AddComponent(typeof(Blackboards.story_node)); //IsContext = True IsNew = True
				Entity AddContext208 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext209 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			
			{
				UnityEngine.GameObject subContext210 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext210 ContextPropertySwitchInterpreter
				if(subContext210 != null)
				{
					
					{
						TaleNode subContext211 = (TaleNode)subContext210.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext211 ContextSwitchInterpreter
						if(subContext211 != null)
						{
							
							subContext211.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class story_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar221 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable212 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable212 != null)
			{
				Blackboards.story_node StoredVariable213 = ((Blackboards.story_node)StoredVariable212.GetComponent(typeof(Blackboards.story_node))); //IsContext = False IsNew = False
				if(StoredVariable213 != null)
				{
					TaleNode StoredVariable214 = ((TaleNode)StoredVariable213.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable214 != null)
					{
						System.Boolean ifResult215; //IsContext = False IsNew = False
						
						System.Boolean OperandVar218 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar216 = default(System.String); //IsContext = False IsNew = False
						OperandVar216 = "decomposed";
						System.Boolean prop217 = StoredVariable212.HasMarker( (OperandVar216)); //IsContext = False IsNew = False
						OperandVar218 = prop217;
						
						System.Boolean OperandVar220 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop219 = StoredVariable214.IsActive; //IsContext = False IsNew = False
						OperandVar220 = prop219;
						if(ifResult215 = ( (!(OperandVar218))) && ( ( (OperandVar220))))
						{
							applicable = true;
							OperandVar221 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar221);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext222 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext222 ContextSwitchInterpreter
				if(subContext222 != null)
				{
					System.String OperandVar223 = default(System.String); //IsContext = False IsNew = False
					OperandVar223 = "decomposed";
					subContext222.SetMarker(( (OperandVar223)).ToString());
				}
			}
			UnityEngine.GameObject c_node = new UnityEngine.GameObject("c_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_node224 = c_node; //IsContext = True IsNew = False
				Markers AddContext225 = (Markers)c_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext226 = (TaleNode)c_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext227 = (Entity)c_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_node AddContext228 = (Blackboards.conflict_node)c_node.AddComponent(typeof(Blackboards.conflict_node)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_node);
			UnityEngine.GameObject c_r_node = new UnityEngine.GameObject("c_r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_r_node229 = c_r_node; //IsContext = True IsNew = False
				Markers AddContext230 = (Markers)c_r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext231 = (TaleNode)c_r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Entity AddContext232 = (Entity)c_r_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Blackboards.conflict_resolution_node AddContext233 = (Blackboards.conflict_resolution_node)c_r_node.AddComponent(typeof(Blackboards.conflict_resolution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.conflict_resolution_node AddContext233 ContextSwitchInterpreter
					if(AddContext233 != null)
					{
						UnityEngine.GameObject OperandVar234 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar234 = c_node;
						AddContext233.Conflict = (UnityEngine.GameObject)( (OperandVar234));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_r_node);
			UnityEngine.GameObject r_node = new UnityEngine.GameObject("r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject r_node235 = r_node; //IsContext = True IsNew = False
				Markers AddContext236 = (Markers)r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext237 = (TaleNode)r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.result_node AddContext238 = (Blackboards.result_node)r_node.AddComponent(typeof(Blackboards.result_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.result_node AddContext238 ContextSwitchInterpreter
					if(AddContext238 != null)
					{
						UnityEngine.GameObject OperandVar239 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar239 = c_r_node;
						AddContext238.Resolution = (UnityEngine.GameObject)( (OperandVar239));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(r_node);
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node240 = s_node; //IsContext = True IsNew = False
				Markers AddContext241 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext242 = (Entity)s_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				TaleNode AddContext243 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.solution_node AddContext244 = (Blackboards.solution_node)s_node.AddComponent(typeof(Blackboards.solution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.solution_node AddContext244 ContextSwitchInterpreter
					if(AddContext244 != null)
					{
						UnityEngine.GameObject OperandVar245 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar245 = c_r_node;
						AddContext244.Cause = (UnityEngine.GameObject)( (OperandVar245));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			UnityEngine.GameObject cris_node = new UnityEngine.GameObject("cris_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cris_node246 = cris_node; //IsContext = True IsNew = False
				Entity AddContext247 = (Entity)cris_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Markers AddContext248 = (Markers)cris_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext249 = (TaleNode)cris_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.crisis_node AddContext250 = (Blackboards.crisis_node)cris_node.AddComponent(typeof(Blackboards.crisis_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.crisis_node AddContext250 ContextSwitchInterpreter
					if(AddContext250 != null)
					{
						UnityEngine.GameObject OperandVar251 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar251 = s_node;
						AddContext250.Solution = (UnityEngine.GameObject)( (OperandVar251));
						UnityEngine.GameObject OperandVar252 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar252 = r_node;
						AddContext250.Cause = (UnityEngine.GameObject)( (OperandVar252));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cris_node);
			
			{
				UnityEngine.GameObject subContext253 = c_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext253 ContextPropertySwitchInterpreter
				if(subContext253 != null)
				{
					
					{
						TaleNode subContext254 = (TaleNode)subContext253.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext254 ContextSwitchInterpreter
						if(subContext254 != null)
						{
							
							subContext254.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext255 = c_r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext255 ContextPropertySwitchInterpreter
				if(subContext255 != null)
				{
					
					{
						TaleNode subContext256 = (TaleNode)subContext255.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext256 ContextSwitchInterpreter
						if(subContext256 != null)
						{
							
							subContext256.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext257 = r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext257 ContextPropertySwitchInterpreter
				if(subContext257 != null)
				{
					
					{
						TaleNode subContext258 = (TaleNode)subContext257.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext258 ContextSwitchInterpreter
						if(subContext258 != null)
						{
							
							subContext258.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext259 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext259 ContextPropertySwitchInterpreter
				if(subContext259 != null)
				{
					
					{
						TaleNode subContext260 = (TaleNode)subContext259.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext260 ContextSwitchInterpreter
						if(subContext260 != null)
						{
							
							subContext260.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext261 = cris_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext261 ContextPropertySwitchInterpreter
				if(subContext261 != null)
				{
					
					{
						TaleNode subContext262 = (TaleNode)subContext261.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext262 ContextSwitchInterpreter
						if(subContext262 != null)
						{
							
							subContext262.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class conflict_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar272 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable263 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable263 != null)
			{
				Blackboards.conflict_node StoredVariable264 = ((Blackboards.conflict_node)StoredVariable263.GetComponent(typeof(Blackboards.conflict_node))); //IsContext = False IsNew = False
				if(StoredVariable264 != null)
				{
					TaleNode StoredVariable265 = ((TaleNode)StoredVariable264.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable265 != null)
					{
						System.Boolean ifResult266; //IsContext = False IsNew = False
						
						System.Boolean OperandVar269 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar267 = default(System.String); //IsContext = False IsNew = False
						OperandVar267 = "decomposed";
						System.Boolean prop268 = StoredVariable263.HasMarker( (OperandVar267)); //IsContext = False IsNew = False
						OperandVar269 = prop268;
						
						System.Boolean OperandVar271 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop270 = StoredVariable265.IsActive; //IsContext = False IsNew = False
						OperandVar271 = prop270;
						if(ifResult266 = ( (!(OperandVar269))) && ( ( (OperandVar271))))
						{
							applicable = true;
							OperandVar272 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar272);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			for (int i = 0; i <  (2f); i++)
			{
				UnityEngine.GameObject f_node = new UnityEngine.GameObject("f_node"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject f_node273 = f_node; //IsContext = True IsNew = False
					TaleNode AddContext274 = (TaleNode)f_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
					Entity AddContext275 = (Entity)f_node.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					Blackboards.faction_node AddContext276 = (Blackboards.faction_node)f_node.AddComponent(typeof(Blackboards.faction_node)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.faction_node AddContext276 ContextSwitchInterpreter
						if(AddContext276 != null)
						{
							UnityEngine.GameObject OperandVar277 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar277 = root;
							AddContext276.Conflict = (UnityEngine.GameObject)( (OperandVar277));
						}
					}
					Markers AddContext278 = (Markers)f_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(f_node);
				
				{
					UnityEngine.GameObject subContext279 = f_node; //IsContext = True IsNew = False
					//ContextStatement UnityEngine.GameObject subContext279 ContextPropertySwitchInterpreter
					if(subContext279 != null)
					{
						
						{
							TaleNode subContext280 = (TaleNode)subContext279.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
							//ContextStatement TaleNode subContext280 ContextSwitchInterpreter
							if(subContext280 != null)
							{
								
								subContext280.IsActive = (System.Boolean)( (true));
							}
						}
					}
				}
			}
			
			{
				Markers subContext281 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext281 ContextSwitchInterpreter
				if(subContext281 != null)
				{
					System.String OperandVar282 = default(System.String); //IsContext = False IsNew = False
					OperandVar282 = "decomposed";
					subContext281.SetMarker(( (OperandVar282)).ToString());
				}
			}
		}
        }
    }
    
    public class tale_ui_enlisting : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar289 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable283 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable283 != null)
			{
				TaleNode StoredVariable284 = ((TaleNode)StoredVariable283.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable284 != null)
				{
					System.Boolean ifResult285; //IsContext = False IsNew = False
					System.Boolean OperandVar288 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar286 = default(System.String); //IsContext = False IsNew = False
					OperandVar286 = "tale_enlisted";
					System.Boolean prop287 = StoredVariable283.HasMarker( (OperandVar286)); //IsContext = False IsNew = False
					OperandVar288 = prop287;
					if(ifResult285 = !(OperandVar288))
					{
						applicable = true;
						OperandVar289 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar289);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject ui = new UnityEngine.GameObject("ui"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject ui290 = ui; //IsContext = True IsNew = False
				UiObject AddContext291 = (UiObject)ui.AddComponent(typeof(UiObject)); //IsContext = True IsNew = True
				
				{
					//ContextStatement UiObject AddContext291 ContextSwitchInterpreter
					if(AddContext291 != null)
					{
						UnityEngine.GameObject OperandVar292 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar292 = root;
						AddContext291.ShowedObject = (UnityEngine.GameObject)( (OperandVar292));
					}
				}
				TextField AddContext293 = (TextField)ui.AddComponent(typeof(TextField)); //IsContext = True IsNew = True
				
				{
					//ContextStatement TextField AddContext293 ContextSwitchInterpreter
					if(AddContext293 != null)
					{
						
						{
							UnityEngine.UI.LayoutElement subContext294 = AddContext293.Layout; //IsContext = True IsNew = False
							//ContextStatement UnityEngine.UI.LayoutElement subContext294 ContextPropertySwitchInterpreter
							if(subContext294 != null)
							{
								
								subContext294.minHeight = (System.Single)( (20f));
							}
						}
						System.String OperandVar297 = default(System.String); //IsContext = False IsNew = False
						UnityEngine.GameObject OperandVar295 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar295 = root;
						System.String prop296 = External.Stringify( (OperandVar295)); //IsContext = False IsNew = False
						if(prop296 != null)
						{
							OperandVar297 = prop296;
						}
						AddContext293.Show(( (OperandVar297)).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(ui);
			UnityEngine.GameObject OperandVar298 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar298 = ui;
			External.TalesUiEnlist((UnityEngine.GameObject)( (OperandVar298)));
			
			{
				Markers subContext299 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext299 ContextSwitchInterpreter
				if(subContext299 != null)
				{
					System.String OperandVar300 = default(System.String); //IsContext = False IsNew = False
					OperandVar300 = "tale_enlisted";
					subContext299.SetUiMarker(( (OperandVar300)).ToString());
				}
			}
		}
        }
    }
    
    public class faction_is_a_state : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar307 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.faction_node StoredVariable301 = ((Blackboards.faction_node)root.GetComponent(typeof(Blackboards.faction_node))); //IsContext = False IsNew = False
			if(StoredVariable301 != null)
			{
				Markers StoredVariable302 = ((Markers)StoredVariable301.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable302 != null)
				{
					System.Boolean ifResult303; //IsContext = False IsNew = False
					System.Boolean OperandVar306 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar304 = default(System.String); //IsContext = False IsNew = False
					OperandVar304 = "faction_is_a_state";
					System.Boolean prop305 = StoredVariable302.HasMarker( (OperandVar304)); //IsContext = False IsNew = False
					OperandVar306 = prop305;
					if(ifResult303 = !(OperandVar306))
					{
						applicable = true;
						OperandVar307 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar307);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.state_node>();
			Entity EntVar308 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar308 != null) EntVar308.ComponentAdded();
			
			{
				Markers subContext309 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext309 ContextSwitchInterpreter
				if(subContext309 != null)
				{
					System.String OperandVar310 = default(System.String); //IsContext = False IsNew = False
					OperandVar310 = "faction_is_a_state";
					subContext309.SetMarker(( (OperandVar310)).ToString());
				}
			}
		}
        }
    }
    
    public class state_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar317 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable311 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable311 != null)
			{
				System.Boolean ifResult312; //IsContext = False IsNew = False
				System.Boolean OperandVar316 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar314 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable313 = ((Named)StoredVariable311.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable313 != null)
				{
					OperandVar314 = StoredVariable313;
				}
				System.Boolean prop315 = External.Has( (OperandVar314)); //IsContext = False IsNew = False
				OperandVar316 = prop315;
				if(ifResult312 = !(OperandVar316))
				{
					applicable = true;
					OperandVar317 = applicable;
				}
			}
			return (System.Boolean) (OperandVar317);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar318 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar318 ContextSwitchInterpreter
				if(ContextVar318 != null)
				{
					
					
					System.String OperandVar321 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar319 = default(System.String); //IsContext = False IsNew = False
					OperandVar319 = "country_name";
					System.String prop320 = External.RandomName( (OperandVar319)); //IsContext = False IsNew = False
					if(prop320 != null)
					{
						OperandVar321 = prop320;
					}
					ContextVar318.Set(( ("main_name")).ToString(),(System.Single)( (0f)),( (OperandVar321)).ToString());
				}
			}
			Entity EntVar322 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar322 != null) EntVar322.ComponentAdded();
		}
        }
    }
    
    public class state_head : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar332 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.state_node StoredVariable323 = ((Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node))); //IsContext = False IsNew = False
			if(StoredVariable323 != null)
			{
				TaleNode StoredVariable324 = ((TaleNode)StoredVariable323.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
				if(StoredVariable324 != null)
				{
					System.Boolean ifResult325; //IsContext = False IsNew = False
					
					System.Boolean OperandVar329 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject OperandVar327 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					if(StoredVariable323 != null)
					{
						UnityEngine.GameObject prop326 = StoredVariable323.Head; //IsContext = False IsNew = False
						if(prop326 != null)
						{
							OperandVar327 = prop326;
						}
					}
					System.Boolean prop328 = External.Has( (OperandVar327)); //IsContext = False IsNew = False
					OperandVar329 = prop328;
					
					System.Boolean OperandVar331 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop330 = StoredVariable324.IsActive; //IsContext = False IsNew = False
					OperandVar331 = prop330;
					if(ifResult325 = ( (!(OperandVar329))) && ( ( (OperandVar331))))
					{
						applicable = true;
						OperandVar332 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar332);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Blackboards.state_node subContext333 = (Blackboards.state_node)root.GetComponent(typeof(Blackboards.state_node)); //IsContext = True IsNew = False
				//ContextStatement Blackboards.state_node subContext333 ContextSwitchInterpreter
				if(subContext333 != null)
				{
					UnityEngine.GameObject head_of_state = new UnityEngine.GameObject("head_of_state"); //IsContext = False IsNew = False
					
					{
						UnityEngine.GameObject head_of_state334 = head_of_state; //IsContext = True IsNew = False
						Markers AddContext335 = (Markers)head_of_state.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
						Blackboards.person_node AddContext336 = (Blackboards.person_node)head_of_state.AddComponent(typeof(Blackboards.person_node)); //IsContext = True IsNew = True
						TaleNode AddContext337 = (TaleNode)head_of_state.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
						Blackboards.head_of_state_node AddContext338 = (Blackboards.head_of_state_node)head_of_state.AddComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = True
						
						{
							//ContextStatement Blackboards.head_of_state_node AddContext338 ContextSwitchInterpreter
							if(AddContext338 != null)
							{
								UnityEngine.GameObject OperandVar339 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
								OperandVar339 = root;
								AddContext338.State = (UnityEngine.GameObject)( (OperandVar339));
							}
						}
						Entity AddContext340 = (Entity)head_of_state.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
					}
					UnityEngine.Object.FindObjectOfType<Generators>().Generate(head_of_state);
					
					{
						UnityEngine.GameObject subContext341 = head_of_state; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext341 ContextPropertySwitchInterpreter
						if(subContext341 != null)
						{
							
							{
								TaleNode subContext342 = (TaleNode)subContext341.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
								//ContextStatement TaleNode subContext342 ContextSwitchInterpreter
								if(subContext342 != null)
								{
									
									subContext342.IsActive = (System.Boolean)( (true));
								}
							}
						}
					}
					UnityEngine.GameObject OperandVar343 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
					OperandVar343 = head_of_state;
					subContext333.Head = (UnityEngine.GameObject)( (OperandVar343));
				}
			}
		}
        }
    }
    
    public class state_head_death : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar358 = default(System.Boolean); //IsContext = False IsNew = False
			Event StoredVariable344 = ((Event)root.GetComponent(typeof(Event))); //IsContext = False IsNew = False
			if(StoredVariable344 != null)
			{
				Markers StoredVariable345 = ((Markers)StoredVariable344.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable345 != null)
				{
					EntityDeathEvent StoredVariable346 = ((EntityDeathEvent)StoredVariable345.GetComponent(typeof(EntityDeathEvent))); //IsContext = False IsNew = False
					if(StoredVariable346 != null)
					{
						System.Boolean ifResult347; //IsContext = False IsNew = False
						
						System.Boolean OperandVar354 = default(System.Boolean); //IsContext = False IsNew = False
						if(StoredVariable344 != null)
						{
							UnityEngine.GameObject prop348 = StoredVariable344.Context; //IsContext = False IsNew = False
							if(prop348 != null)
							{
								System.Boolean ifResult349; //IsContext = False IsNew = False
								System.Boolean OperandVar353 = default(System.Boolean); //IsContext = False IsNew = False
								Blackboards.head_of_state_node OperandVar351 = default(Blackboards.head_of_state_node); //IsContext = False IsNew = False
								Blackboards.head_of_state_node StoredVariable350 = ((Blackboards.head_of_state_node)prop348.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
								if(StoredVariable350 != null)
								{
									OperandVar351 = StoredVariable350;
								}
								System.Boolean prop352 = External.Has( (OperandVar351)); //IsContext = False IsNew = False
								OperandVar353 = prop352;
								if(ifResult349 =  (OperandVar353))
								{
									OperandVar354 = ifResult349;
								}
							}
						}
						
						System.Boolean OperandVar357 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar355 = default(System.String); //IsContext = False IsNew = False
						OperandVar355 = "state_head_death_reacted";
						System.Boolean prop356 = StoredVariable345.HasMarker( (OperandVar355)); //IsContext = False IsNew = False
						OperandVar357 = prop356;
						if(ifResult347 = ( ( (OperandVar354))) && ( (!(OperandVar357))))
						{
							applicable = true;
							OperandVar358 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar358);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext359 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext359 ContextSwitchInterpreter
				if(subContext359 != null)
				{
					System.String OperandVar360 = default(System.String); //IsContext = False IsNew = False
					OperandVar360 = "state_head_death_reacted";
					subContext359.SetMarker(( (OperandVar360)).ToString());
				}
			}
			
			{
				Event subContext361 = (Event)root.GetComponent(typeof(Event)); //IsContext = True IsNew = False
				//ContextStatement Event subContext361 ContextSwitchInterpreter
				if(subContext361 != null)
				{
					
					{
						UnityEngine.GameObject subContext362 = subContext361.Context; //IsContext = True IsNew = False
						//ContextStatement UnityEngine.GameObject subContext362 ContextPropertySwitchInterpreter
						if(subContext362 != null)
						{
							
							{
								Blackboards.head_of_state_node subContext363 = (Blackboards.head_of_state_node)subContext362.GetComponent(typeof(Blackboards.head_of_state_node)); //IsContext = True IsNew = False
								//ContextStatement Blackboards.head_of_state_node subContext363 ContextSwitchInterpreter
								if(subContext363 != null)
								{
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class state_head_name : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar370 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.head_of_state_node StoredVariable364 = ((Blackboards.head_of_state_node)root.GetComponent(typeof(Blackboards.head_of_state_node))); //IsContext = False IsNew = False
			if(StoredVariable364 != null)
			{
				System.Boolean ifResult365; //IsContext = False IsNew = False
				System.Boolean OperandVar369 = default(System.Boolean); //IsContext = False IsNew = False
				Named OperandVar367 = default(Named); //IsContext = False IsNew = False
				Named StoredVariable366 = ((Named)StoredVariable364.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable366 != null)
				{
					OperandVar367 = StoredVariable366;
				}
				System.Boolean prop368 = External.Has( (OperandVar367)); //IsContext = False IsNew = False
				OperandVar369 = prop368;
				if(ifResult365 = !(OperandVar369))
				{
					applicable = true;
					OperandVar370 = applicable;
				}
			}
			return (System.Boolean) (OperandVar370);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			Named ContextVar371 = root.AddComponent<Named>();; //IsContext = False IsNew = True
			
			{
				//ContextStatement Named ContextVar371 ContextSwitchInterpreter
				if(ContextVar371 != null)
				{
					System.String OperandVar372 = default(System.String); //IsContext = False IsNew = False
					OperandVar372 = "main_name";
					
					System.String OperandVar375 = default(System.String); //IsContext = False IsNew = False
					System.String OperandVar373 = default(System.String); //IsContext = False IsNew = False
					OperandVar373 = "human_name";
					System.String prop374 = External.RandomName( (OperandVar373)); //IsContext = False IsNew = False
					if(prop374 != null)
					{
						OperandVar375 = prop374;
					}
					ContextVar371.Set(( (OperandVar372)).ToString(),(System.Single)( (0f)),( (OperandVar375)).ToString());
				}
			}
			Entity EntVar376 = (Entity)root.GetComponent(typeof(Entity));; //IsContext = False IsNew = False
			if(EntVar376 != null) EntVar376.ComponentAdded();
		}
        }
    }
    
    public class map_anchored : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar386 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable377 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable377 != null)
			{
				Markers StoredVariable378 = ((Markers)StoredVariable377.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable378 != null)
				{
					System.Boolean ifResult379; //IsContext = False IsNew = False
					
					System.Boolean OperandVar382 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar380 = default(System.String); //IsContext = False IsNew = False
					OperandVar380 = "map_anchored";
					System.Boolean prop381 = StoredVariable378.HasMarker( (OperandVar380)); //IsContext = False IsNew = False
					OperandVar382 = prop381;
					
					System.Boolean OperandVar385 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar383 = default(System.String); //IsContext = False IsNew = False
					OperandVar383 = "history_place";
					System.Boolean prop384 = StoredVariable378.HasMarker( (OperandVar383)); //IsContext = False IsNew = False
					OperandVar385 = prop384;
					if(ifResult379 = ( (!(OperandVar382))) && ( ( (OperandVar385))))
					{
						applicable = true;
						OperandVar386 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar386);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext387 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext387 ContextSwitchInterpreter
				if(subContext387 != null)
				{
					System.String OperandVar388 = default(System.String); //IsContext = False IsNew = False
					OperandVar388 = "map_anchored";
					subContext387.SetUiMarker(( (OperandVar388)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar389 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar389 = root;
			External.MapEnlist((UnityEngine.GameObject)( (OperandVar389)));
		}
        }
    }
    
    public class encounter_ui_enlist : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar396 = default(System.Boolean); //IsContext = False IsNew = False
			Encounter StoredVariable390 = ((Encounter)root.GetComponent(typeof(Encounter))); //IsContext = False IsNew = False
			if(StoredVariable390 != null)
			{
				Markers StoredVariable391 = ((Markers)StoredVariable390.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
				if(StoredVariable391 != null)
				{
					System.Boolean ifResult392; //IsContext = False IsNew = False
					System.Boolean OperandVar395 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar393 = default(System.String); //IsContext = False IsNew = False
					OperandVar393 = "encounter_ui_enlist";
					System.Boolean prop394 = StoredVariable391.HasMarker( (OperandVar393)); //IsContext = False IsNew = False
					OperandVar395 = prop394;
					if(ifResult392 = !(OperandVar395))
					{
						applicable = true;
						OperandVar396 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar396);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext397 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext397 ContextSwitchInterpreter
				if(subContext397 != null)
				{
					System.String OperandVar398 = default(System.String); //IsContext = False IsNew = False
					OperandVar398 = "encounter_ui_enlist";
					subContext397.SetUiMarker(( (OperandVar398)).ToString());
				}
			}
			UnityEngine.GameObject OperandVar399 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar399 = root;
			External.EnlistEncounter((UnityEngine.GameObject)( (OperandVar399)));
		}
        }
    }
    
    public class location_test_encounter : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar405 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable400 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable400 != null)
			{
				Named StoredVariable401 = ((Named)StoredVariable400.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable401 != null)
				{
					System.Boolean ifResult402; //IsContext = False IsNew = False
					
					System.Boolean OperandVar404 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable400 != null)
					{
						System.Boolean prop403 = StoredVariable400.Act; //IsContext = False IsNew = False
						OperandVar404 = prop403;
					}
					
					
					if(ifResult402 = ( ( (OperandVar404))) == ( ( (true))))
					{
						applicable = true;
						OperandVar405 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar405);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.4f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			UnityEngine.GameObject enc = new UnityEngine.GameObject("enc"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject enc406 = enc; //IsContext = True IsNew = False
				Encounter AddContext407 = (Encounter)enc.AddComponent(typeof(Encounter)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Encounter AddContext407 ContextSwitchInterpreter
					if(AddContext407 != null)
					{
						UnityEngine.GameObject OperandVar408 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar408 = root;
						AddContext407.Context = (UnityEngine.GameObject)( (OperandVar408));
					}
				}
				Markers AddContext409 = (Markers)enc.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				Entity AddContext410 = (Entity)enc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
				Named AddContext411 = (Named)enc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Named AddContext411 ContextSwitchInterpreter
					if(AddContext411 != null)
					{
						System.String OperandVar412 = default(System.String); //IsContext = False IsNew = False
						OperandVar412 = "main_name";
						
						
						AddContext411.Set(( (OperandVar412)).ToString(),(System.Single)( (0f)),( ("Basic encounter")).ToString());
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(enc);
		}
        }
    }
}
